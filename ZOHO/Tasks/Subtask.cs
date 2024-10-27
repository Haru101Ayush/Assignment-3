using Newtonsoft.Json;

namespace Zoho_Migration.ZOHO.Tasks
{
    
    public class ASSOCIATEDTEAMS
    {
        [JsonProperty("AnyTeam")]
        public string AnyTeam;
    }

    public class CustomField
    {
        [JsonProperty("column_name")]
        public string ColumnName;

        [JsonProperty("label_name")]
        public string LabelName;

        [JsonProperty("value")]
        public string Value;
    }

    public class SubTaskDetails
    {
        [JsonProperty("owners")]
        public List<Owner> Owners;
    }

    public class GROUPNAME
    {
        [JsonProperty("ASSOCIATED_TEAMS")]
        public ASSOCIATEDTEAMS ASSOCIATEDTEAMS;

        [JsonProperty("ASSOCIATED_TEAMS_COUNT")]
        public int? ASSOCIATEDTEAMSCOUNT;

        [JsonProperty("IS_TEAM_UNASSIGNED")]
        public bool? ISTEAMUNASSIGNED;
    }

    public class SubTaskLink
    {
        [JsonProperty("timesheet")]
        public Timesheet Timesheet;

        [JsonProperty("web")]
        public Web Web;

        [JsonProperty("self")]
        public Self Self;
    }

    public class SubTaskLogHours
    {
        [JsonProperty("non_billable_hours")]
        public string NonBillableHours;

        [JsonProperty("billable_hours")]
        public string BillableHours;
    }

    public class SubTaskOwner
    {
        [JsonProperty("work")]
        public string Work;

        [JsonProperty("name")]
        public string Name;
    }

    public class SubTasklist
    {
        [JsonProperty("tasks")]
        public List<STask> Tasks;
    }

    public class Self
    {
        [JsonProperty("url")]
        public string Url;
    }

    public class SubTaskStatus
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("color_code")]
        public string ColorCode;
    }

    public class STask
    {
        [JsonProperty("parent_task_id")]
        public string ParentTaskId;

        [JsonProperty("is_comment_added")]
        public bool? IsCommentAdded;

        [JsonProperty("added_via")]
        public string AddedVia;

        [JsonProperty("last_updated_time_long")]
        public long? LastUpdatedTimeLong;

        [JsonProperty("is_forum_associated")]
        public bool? IsForumAssociated;

        [JsonProperty("details")]
        public Details Details;

        [JsonProperty("id")]
        public long? Id;

        [JsonProperty("created_time")]
        public string CreatedTime;

        [JsonProperty("work")]
        public string Work;

        [JsonProperty("custom_fields")]
        public List<CustomField> CustomFields;

        [JsonProperty("isparent")]
        public bool? Isparent;

        [JsonProperty("work_type")]
        public string WorkType;

        [JsonProperty("completed")]
        public bool? Completed;

        [JsonProperty("task_followers")]
        public TaskFollowers TaskFollowers;

        [JsonProperty("priority")]
        public string Priority;

        [JsonProperty("created_by")]
        public string CreatedBy;

        [JsonProperty("last_updated_time")]
        public string LastUpdatedTime;

        [JsonProperty("root_task_id")]
        public string RootTaskId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("is_docs_assocoated")]
        public bool? IsDocsAssocoated;

        [JsonProperty("tasklist")]
        public Tasklist Tasklist;

        [JsonProperty("last_updated_time_format")]
        public string LastUpdatedTimeFormat;

        [JsonProperty("billingtype")]
        public string Billingtype;

        [JsonProperty("order_sequence")]
        public int? OrderSequence;

        [JsonProperty("status")]
        public Status Status;

        [JsonProperty("milestone_id")]
        public string MilestoneId;

        [JsonProperty("link")]
        public Link Link;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("created_by_zpuid")]
        public string CreatedByZpuid;

        [JsonProperty("work_form")]
        public string WorkForm;

        [JsonProperty("duration")]
        public string Duration;

        [JsonProperty("created_by_email")]
        public string CreatedByEmail;

        [JsonProperty("key")]
        public string Key;

        [JsonProperty("created_person")]
        public string CreatedPerson;

        [JsonProperty("created_time_long")]
        public long? CreatedTimeLong;

        [JsonProperty("is_reminder_set")]
        public bool? IsReminderSet;

        [JsonProperty("is_recurrence_set")]
        public bool? IsRecurrenceSet;

        [JsonProperty("created_time_format")]
        public string CreatedTimeFormat;

        [JsonProperty("created_by_full_name")]
        public string CreatedByFullName;

        [JsonProperty("subtasks")]
        public bool? Subtasks;

        [JsonProperty("duration_type")]
        public string DurationType;

        [JsonProperty("parenttask_id")]
        public string ParenttaskId;

        [JsonProperty("percent_complete")]
        public string PercentComplete;

        [JsonProperty("GROUP_NAME")]
        public GROUPNAME GROUPNAME;

        [JsonProperty("depth")]
        public int? Depth;

        [JsonProperty("id_string")]
        public string IdString;

        [JsonProperty("log_hours")]
        public LogHours LogHours;
    }

    public class SubTaskTaskFollowers
    {
        [JsonProperty("FOLUSERS")]
        public string FOLUSERS;

        [JsonProperty("FOLLOWERSIZE")]
        public int? FOLLOWERSIZE;

        [JsonProperty("FOLLOWERS")]
        public List<object> FOLLOWERS;
    }

    public class Tasklist
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id_string")]
        public string IdString;

        [JsonProperty("id")]
        public string Id;
    }

    public class Timesheet
    {
        [JsonProperty("url")]
        public string Url;
    }

    public class Web
    {
        [JsonProperty("url")]
        public string Url;
    }


}
