using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zoho_Migration.ZOHO.User
{
    public class UsersResponse
    {
        [JsonPropertyName("users")]
        public List<User> Users { get; set; }
    }

    public class User
    {
        [JsonPropertyName("profile_type")]
        public string ProfileType { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("portal_role_name")]
        public string PortalRoleName { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("zpuid")]
        public string Zpuid { get; set; }

        [JsonPropertyName("project_profile_id")]
        public string ProjectProfileId { get; set; }

        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("portal_profile_name")]
        public string PortalProfileName { get; set; }

        [JsonPropertyName("portal_role_id")]
        public string PortalRoleId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("chat_access")]
        public bool ChatAccess { get; set; }

        [JsonPropertyName("is_resource")]
        public bool IsResource { get; set; }
    }

}
