using BungieAPITest.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace BungieAPITest {
    class Program {
        private const string _bungieUrl = "https://www.bungie.net/platform/";
        static async Task Main(string[] args) {
            var apiKey = "97bb1711e6804f2fb5d9007d987748a5";
            var userCode = "9e1e91002cabfc5f39840b5ffa9f9ba2";
            using (var client = new HttpClient()) {
                client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
                client.Timeout = TimeSpan.FromMinutes(5);

                //Get MemberShip ID and Token
                var accessTokenResult = await GetMembershipAndToken(client, userCode, apiKey);
                //Get Memberships For Profile
                var membershipResponse = await GetMembership(client, accessTokenResult.MembershipId);
                var actualMemberships = membershipResponse.Response.destinyMemberships;
                var steamMembership = actualMemberships.First(x => x.membershipType == 3);
                //Get Profile For Characters
                var profileResponse = await GetAllCharacters(client, steamMembership.membershipId);
                // Get Activities for each Character
                var activityResponse = await GetActivities(client, steamMembership.membershipId, profileResponse.Response.profile.data.characterIds);
                // Get Reports for each Character
                var activitiesToGetReportsFor = activityResponse.SelectMany(x => x.Response.activities.Select(y => y.activityDetails.instanceId));
                var reports = await GetReports(client, activitiesToGetReportsFor);
                // Filter For the Player
                var entriesForPlayer = reports.SelectMany(x => x?.Response.entries.Where(y => profileResponse.Response.profile.data.characterIds.Contains(y.characterId)));
                var entriesWithWeapons = entriesForPlayer.Where(x => x.extended.weapons != null);
                var distinctWeapon = entriesWithWeapons.SelectMany(x => x.extended.weapons.Select(x => x.referenceId)).Distinct();
                var weaponWithKills = new Dictionary<long, long>();
                foreach (var weapon in distinctWeapon) {
                // Count
                    var entriesWithCurrentWeapon = entriesWithWeapons.SelectMany(x => x?.extended?.weapons).Where(y => y?.referenceId == weapon);
                    var entriesWithDisplayValue = entriesWithCurrentWeapon.Where(x => x.values.uniqueWeaponKills.basic != null && x.values.uniqueWeaponPrecisionKills.basic != null);
                    weaponWithKills.Add(weapon, entriesWithDisplayValue.Sum(x => long.Parse(x.values?.uniqueWeaponKills?.basic?.displayValue)));
                }
                // Search for Thorn
                Console.WriteLine(weaponWithKills[3973202132].ToString());
            }

        }

        private static async Task<IEnumerable<ReportResponse>> GetReports(HttpClient client, IEnumerable<string> activitiesToGetReportsFor) {
            var returnResult = new ConcurrentBag<ReportResponse>();
            var toQueryUrls = activitiesToGetReportsFor.Select(activity => "https://stats.bungie.net/platform/Destiny2/Stats/PostGameCarnageReport/" + activity);
            var tasks = new List<Task>();
            var throttler = new SemaphoreSlim(20);
            foreach(var url in toQueryUrls) {
                await throttler.WaitAsync();

                tasks.Add(Task.Run(async () => {
                    try {
                        var result = await client.GetAsync(url);
                        if (result.IsSuccessStatusCode) {
                            returnResult.Add(JsonSerializer.Deserialize<ReportResponse>(await result.Content.ReadAsStringAsync()));
                        }
                    } finally {
                        throttler.Release();
                    }
                }))
            ;}
            await Task.WhenAll(tasks);
            //foreach (var activity in activitiesToGetReportsFor) {
            //    var result = await client.GetAsync("https://stats.bungie.net/platform/Destiny2/Stats/PostGameCarnageReport/" + activity);
            //    if (result.IsSuccessStatusCode) {
            //        returnResult.Add(JsonSerializer.Deserialize<ReportResponse>(await result.Content.ReadAsStringAsync()));
            //    }
            //}
            //var parallelRequests = activitiesToGetReportsFor.Select(x => GetReport(client, x));
            //returnResult.AddRange(await Task.WhenAll(parallelRequests));
            return returnResult;
        }

        private static async Task<ReportResponse> GetReport(HttpClient client, string activity) {
            var result = await client.GetAsync("https://stats.bungie.net/platform/Destiny2/Stats/PostGameCarnageReport/" + activity);
            if (result.IsSuccessStatusCode) {
                return JsonSerializer.Deserialize<ReportResponse>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        private static async Task<List<ActivityResponse>> GetActivities(HttpClient client, string membershipId, List<string> characterIds) {
            var returnResult = new List<ActivityResponse>();
            foreach (var character in characterIds) {
                var hasResponse = true;
                var page = 0;
                while (hasResponse) {
                    var result = await client.GetAsync(_bungieUrl + $"/Destiny2/3/Account/{membershipId}/Character/{character}/Stats/Activities/?mode=7&page={page}");
                    var response = JsonSerializer.Deserialize<ActivityResponse>(await result.Content.ReadAsStringAsync());
                    if (response.Response.activities != null) {
                        returnResult.Add(response);
                        page++;
                    }
                    else {
                        hasResponse = false;
                    }
                }
            }
            return returnResult;
        }

        private static async Task<ProfileResponse> GetAllCharacters(HttpClient client, string destinyMembership) {
            var result = await client.GetAsync(_bungieUrl + $"Destiny2/3/profile/{destinyMembership}/?components=100");
            return JsonSerializer.Deserialize<ProfileResponse>(await result.Content.ReadAsStringAsync());
        }

        private static async Task<MembershipResponse> GetMembership(HttpClient client, string membershipId) {
            var result = await client.GetAsync(_bungieUrl + $"/User/GetMembershipsById/{membershipId}/4/");
            return JsonSerializer.Deserialize<MembershipResponse>(await result.Content.ReadAsStringAsync());
        }

        private static async Task<AccessTokenResponse> GetMembershipAndToken(HttpClient client, string userCode, string apiKey) {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("grant_type", "authorization_code");
            pairs.Add("code", userCode);
            pairs.Add("client_id", "29491");


            var content = new FormUrlEncodedContent(pairs);
            var result = await client.PostAsync(_bungieUrl + $"app/oauth/token/", content);
            return JsonSerializer.Deserialize<AccessTokenResponse>(await result.Content.ReadAsStringAsync());
        }
    }
}
