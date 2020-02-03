using System;
using System.Collections.Generic;
using System.Text;

namespace BungieAPITest.Models {
    public class ReportResponseActivityDetails {
        public int referenceId { get; set; }
        public int directorActivityHash { get; set; }
        public string instanceId { get; set; }
        public int mode { get; set; }
        public List<int> modes { get; set; }
        public bool isPrivate { get; set; }
        public int membershipType { get; set; }
    }

    public class ReportResponseBasic {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseScore {
        public Basic basic { get; set; }
    }

    public class DestinyUserInfo {
        public string iconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public List<int> applicableMembershipTypes { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
    }

    public class Player {
        public DestinyUserInfo destinyUserInfo { get; set; }
        public string characterClass { get; set; }
        public object classHash { get; set; }
        public long raceHash { get; set; }
        public object genderHash { get; set; }
        public int characterLevel { get; set; }
        public int lightLevel { get; set; }
        public object emblemHash { get; set; }
    }

    public class ReportResponseBasic2 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseAssists {
        public Basic2 basic { get; set; }
    }

    public class ReportResponseReportResponseBasic3 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseCompleted {
        public Basic3 basic { get; set; }
    }

    public class ReportResponseBasic4 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseDeaths {
        public Basic4 basic { get; set; }
    }

    public class ReportResponseBasic5 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseKills {
        public Basic5 basic { get; set; }
    }

    public class ReportResponseBasic6 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseOpponentsDefeated {
        public Basic6 basic { get; set; }
    }

    public class ReportResponseBasic7 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseEfficiency {
        public Basic7 basic { get; set; }
    }

    public class ReportResponseBasic8 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseKillsDeathsRatio {
        public Basic8 basic { get; set; }
    }

    public class ReportResponseBasic9 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseKillsDeathsAssists {
        public Basic9 basic { get; set; }
    }

    public class ReportResponseBasic10 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Score2 {
        public Basic10 basic { get; set; }
    }

    public class ReportResponseBasic11 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseActivityDurationSeconds {
        public Basic11 basic { get; set; }
    }

    public class ReportResponseBasic12 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseCompletionReason {
        public Basic12 basic { get; set; }
    }

    public class ReportResponseBasic13 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseFireteamId {
        public Basic13 basic { get; set; }
    }

    public class ReportResponseBasic14 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseStartSeconds {
        public Basic14 basic { get; set; }
    }

    public class ReportResponseBasic15 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseTimePlayedSeconds {
        public Basic15 basic { get; set; }
    }

    public class ReportResponseBasic16 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponsePlayerCount {
        public Basic16 basic { get; set; }
    }

    public class ReportResponseBasic17 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ReportResponseTeamScore {
        public Basic17 basic { get; set; }
    }

    public class ReportResponseValues {
        public Assists assists { get; set; }
        public Completed completed { get; set; }
        public Deaths deaths { get; set; }
        public Kills kills { get; set; }
        public OpponentsDefeated opponentsDefeated { get; set; }
        public Efficiency efficiency { get; set; }
        public KillsDeathsRatio killsDeathsRatio { get; set; }
        public KillsDeathsAssists killsDeathsAssists { get; set; }
        public Score2 score { get; set; }
        public ActivityDurationSeconds activityDurationSeconds { get; set; }
        public CompletionReason completionReason { get; set; }
        public FireteamId fireteamId { get; set; }
        public StartSeconds startSeconds { get; set; }
        public TimePlayedSeconds timePlayedSeconds { get; set; }
        public PlayerCount playerCount { get; set; }
        public TeamScore teamScore { get; set; }
    }

    public class Basic18 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class PrecisionKills {
        public Basic18 basic { get; set; }
    }

    public class Basic19 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class WeaponKillsGrenade {
        public Basic19 basic { get; set; }
    }

    public class Basic20 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class WeaponKillsMelee {
        public Basic20 basic { get; set; }
    }

    public class Basic21 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class WeaponKillsSuper {
        public Basic21 basic { get; set; }
    }

    public class Basic22 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class WeaponKillsAbility {
        public Basic22 basic { get; set; }
    }

    public class Values2 {
        public PrecisionKills precisionKills { get; set; }
        public WeaponKillsGrenade weaponKillsGrenade { get; set; }
        public WeaponKillsMelee weaponKillsMelee { get; set; }
        public WeaponKillsSuper weaponKillsSuper { get; set; }
        public WeaponKillsAbility weaponKillsAbility { get; set; }
    }

    public class Basic23 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class UniqueWeaponKills {
        public Basic23 basic { get; set; }
    }

    public class Basic24 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class UniqueWeaponPrecisionKills {
        public Basic24 basic { get; set; }
    }

    public class Basic25 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class UniqueWeaponKillsPrecisionKills {
        public Basic25 basic { get; set; }
    }

    public class Values3 {
        public UniqueWeaponKills uniqueWeaponKills { get; set; }
        public UniqueWeaponPrecisionKills uniqueWeaponPrecisionKills { get; set; }
        public UniqueWeaponKillsPrecisionKills uniqueWeaponKillsPrecisionKills { get; set; }
    }

    public class Weapon {
        public long referenceId { get; set; }
        public Values3 values { get; set; }
    }

    public class Extended {
        public Values2 values { get; set; }
        public List<Weapon> weapons { get; set; }
    }

    public class Entry {
        public int standing { get; set; }
        public Score score { get; set; }
        public Player player { get; set; }
        public string characterId { get; set; }
        public Values values { get; set; }
        public Extended extended { get; set; }
    }

    public class ReportResponseResponse {
        public DateTime period { get; set; }
        public int startingPhaseIndex { get; set; }
        public ActivityDetails activityDetails { get; set; }
        public List<Entry> entries { get; set; }
        public List<object> teams { get; set; }
    }

    public class ReportResponseMessageData {
    }

    public class ReportResponse {
        public ReportResponseResponse Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public ReportResponseMessageData MessageData { get; set; }
    }
}
