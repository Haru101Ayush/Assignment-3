using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zoho_Migration.ZOHO.TimeSheet
{
    public class Timelogs
    {
        [JsonPropertyName("total_log_hours")]
        public string TotalLogHours { get; set; }

        [JsonPropertyName("tasklogs")]
        public List<Tasklog> TaskLogs { get; set; }
    }

    public class Tasklog
    {
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("last_modified_date")]
        public string LastModifiedDate { get; set; }

        [JsonPropertyName("log_date_long")]
        public long LogDateLong { get; set; }

        [JsonPropertyName("is_parent")]
        public bool IsParent { get; set; }

        [JsonPropertyName("sub_task_level")]
        public string SubTaskLevel { get; set; }

        [JsonPropertyName("last_modified_time_long")]
        public long LastModifiedTimeLong { get; set; }

        [JsonPropertyName("added_by")]
        public AddedBy AddedBy { get; set; }

        [JsonPropertyName("added_via")]
        public string AddedVia { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("task_list")]
        public TaskList TaskList { get; set; }

        [JsonPropertyName("log_date_format")]
        public string LogDateFormat { get; set; }

        [JsonPropertyName("created_time_long")]
        public long CreatedTimeLong { get; set; }

        [JsonPropertyName("hours")]
        public int Hours { get; set; }

        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        [JsonPropertyName("created_time_format")]
        public string CreatedTimeFormat { get; set; }

        [JsonPropertyName("is_sub_task")]
        public bool IsSubTask { get; set; }

        [JsonPropertyName("minutes")]
        public int Minutes { get; set; }

        [JsonPropertyName("total_minutes")]
        public int TotalMinutes { get; set; }

        [JsonPropertyName("approver_name")]
        public string ApproverName { get; set; }

        [JsonPropertyName("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }

        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        [JsonPropertyName("last_modified_time_format")]
        public string LastModifiedTimeFormat { get; set; }

        [JsonPropertyName("task")]
        public Task Task { get; set; }

        [JsonPropertyName("log_date")]
        public string LogDate { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("created_date")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("hours_display")]
        public string HoursDisplay { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("self")]
        public Url Self { get; set; }
    }

    public class Url
    {
        [JsonPropertyName("url")]
        public string UrlValue { get; set; }
    }

    public class AddedBy
    {
        [JsonPropertyName("zpuid")]
        public string Zpuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("zuid")]
        public long Zuid { get; set; }
    }

    public class TaskList
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }
    }

    public class Task
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }
    }

}
