using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zoho_Migration.ZOHO.Tasks
{
    public class Project_Task
    {
        [JsonPropertyName("start_date_long")]
        public long StartDateLong { get; set; }

        [JsonPropertyName("is_comment_added")]
        public bool IsCommentAdded { get; set; }

        [JsonPropertyName("end_date_format")]
        public string EndDateFormat { get; set; }

        [JsonPropertyName("added_via")]
        public string AddedVia { get; set; }

        [JsonPropertyName("last_updated_time_long")]
        public long LastUpdatedTimeLong { get; set; }

        [JsonPropertyName("is_forum_associated")]
        public bool IsForumAssociated { get; set; }

        [JsonPropertyName("details")]
        public Details Details { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        [JsonPropertyName("work")]
        public string Work { get; set; }

        [JsonPropertyName("custom_fields")]
        public List<dynamic> CustomFields { get; set; }

        [JsonPropertyName("start_date_format")]
        public string StartDateFormat { get; set; }

        [JsonPropertyName("isparent")]
        public bool IsParent { get; set; }

        [JsonPropertyName("work_type")]
        public string WorkType { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("task_followers")]
        public TaskFollowers TaskFollowers { get; set; }

        [JsonPropertyName("priority")]
        public string Priority { get; set; }

        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("last_updated_time")]
        public string LastUpdatedTime { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_docs_assocoated")]
        public bool IsDocsAssociated { get; set; }

        [JsonPropertyName("tasklist")]
        public TaskList TaskList { get; set; }

        [JsonPropertyName("last_updated_time_format")]
        public string LastUpdatedTimeFormat { get; set; }

        [JsonPropertyName("billingtype")]
        public string BillingType { get; set; }

        [JsonPropertyName("order_sequence")]
        public int OrderSequence { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        [JsonPropertyName("milestone_id")]
        public string MilestoneId { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_by_zpuid")]
        public string CreatedByZpuid { get; set; }

        [JsonPropertyName("work_form")]
        public string WorkForm { get; set; }

        [JsonPropertyName("end_date_long")]
        public long EndDateLong { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("created_by_email")]
        public string CreatedByEmail { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("created_person")]
        public string CreatedPerson { get; set; }

        [JsonPropertyName("created_time_long")]
        public long CreatedTimeLong { get; set; }

        [JsonPropertyName("is_reminder_set")]
        public bool IsReminderSet { get; set; }

        [JsonPropertyName("is_recurrence_set")]
        public bool IsRecurrenceSet { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags;

        [JsonPropertyName("created_time_format")]
        public string CreatedTimeFormat { get; set; }

        [JsonPropertyName("created_by_full_name")]
        public string CreatedByFullName { get; set; }

        [JsonPropertyName("subtasks")]
        public bool Subtasks { get; set; }

        [JsonPropertyName("duration_type")]
        public string DurationType { get; set; }

        [JsonPropertyName("percent_complete")] 
        public string PercentComplete { get; set; }

        [JsonPropertyName("GROUP_NAME")]
        public GroupName GroupName { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("log_hours")]
        public LogHours LogHours { get; set; }
    }

    public class Details
    {
        [JsonPropertyName("owners")]
        public List<Owner> Owners { get; set; }
    }

    public class Owner
    {
        [JsonPropertyName("zpuid")]
        public string Zpuid { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

    public class TaskFollowers
    {
        [JsonPropertyName("FOLUSERS")]
        public string FolUsers { get; set; }

        [JsonPropertyName("FOLLOWERSIZE")]
        public int FollowerSize { get; set; }

        [JsonPropertyName("FOLLOWERS")]
        public List<Following_User> Followers { get; set; }
    }
    public class Following_User
    {
        [JsonProperty("FPHOTO")]
        public string FPHOTO;

        [JsonProperty("FOLLOWERID")]
        public string FOLLOWERID;

        [JsonProperty("FNAME")]
        public string FNAME;
    }
    public class TaskList
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("color_code")]
        public string ColorCode { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("timesheet")]
        public Url Timesheet { get; set; }

        [JsonPropertyName("web")]
        public Url Web { get; set; }

        [JsonPropertyName("self")]
        public Url Self { get; set; }

        [JsonPropertyName("subtask")]
        public Url Subtask { get; set; }

    }

   
    public class Url
    {
        [JsonPropertyName("url")]
        public string UrlValue { get; set; }
    }

    public class GroupName
    {
        [JsonPropertyName("ASSOCIATED_TEAMS")]
        public AssociatedTeams AssociatedTeams { get; set; }

        [JsonPropertyName("ASSOCIATED_TEAMS_COUNT")]
        public int AssociatedTeamsCount { get; set; }

        [JsonPropertyName("IS_TEAM_UNASSIGNED")]
        public bool IsTeamUnassigned { get; set; }
    }

    public class AssociatedTeams
    {
        [JsonPropertyName("AnyTeam")]
        public string AnyTeam { get; set; }
    }

    public class LogHours
    {
        [JsonPropertyName("non_billable_hours")]
        public string NonBillableHours { get; set; }

        [JsonPropertyName("billable_hours")]
        public string BillableHours { get; set; }
    }

    public class Tag
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("color_class")]
        public string ColorClass;
    }
}
