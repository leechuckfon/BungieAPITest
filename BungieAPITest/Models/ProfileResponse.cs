using System;
using System.Collections.Generic;
using System.Text;

namespace BungieAPITest.Models {
    public class UserInfo {
        public int crossSaveOverride { get; set; }
        public List<int> applicableMembershipTypes { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
    }

    public class Data {
        public UserInfo userInfo { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public int versionsOwned { get; set; }
        public List<string> characterIds { get; set; }
        public List<object> seasonHashes { get; set; }
        public int currentSeasonHash { get; set; }
    }

    public class Profile {
        public Data data { get; set; }
        public int privacy { get; set; }
    }

    public class ProfileResponseResponse {
        public Profile profile { get; set; }
    }

    public class ProfileResponseMessageData {
    }

    public class ProfileResponse {
        public ProfileResponseResponse Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public ProfileResponseMessageData MessageData { get; set; }
    }
}
