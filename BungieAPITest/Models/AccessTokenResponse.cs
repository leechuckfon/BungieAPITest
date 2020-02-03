using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BungieAPITest.Models {
    class AccessTokenResponse {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonPropertyName("membership_id")]
        public string MembershipId { get; set; }
    }
}
