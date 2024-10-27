using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zoho_Migration.ZOHO.Tasks.Task_Comments
{
    public class CommentsResponse
    {
        [JsonPropertyName("comments")]
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        [JsonPropertyName("created_time_long")]
        public long CreatedTimeLong { get; set; }

        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        [JsonPropertyName("thirdparty_attachments")]
        public List<string> ThirdPartyAttachments { get; set; }

        [JsonPropertyName("attachments")]
        public List<string> Attachments { get; set; }

        [JsonPropertyName("last_modified_time")]
        public string LastModifiedTime { get; set; }

        [JsonPropertyName("created_time_format")]
        public string CreatedTimeFormat { get; set; }

        [JsonPropertyName("project")]
        public ProjectC Project { get; set; }

        [JsonPropertyName("added_person")]
        public string AddedPerson { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("last_modified_time_long")]
        public long LastModifiedTimeLong { get; set; }

        [JsonPropertyName("last_modified_time_format")]
        public string LastModifiedTimeFormat { get; set; }

        [JsonPropertyName("sprints_notes_id")]
        public int SprintsNotesId { get; set; }

        [JsonPropertyName("added_via")]
        public string AddedVia { get; set; }

        [JsonPropertyName("added_by")]
        public string AddedBy { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }
    }

    public class ProjectC
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

}
