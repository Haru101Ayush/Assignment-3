using System;
using System.Collections.Generic;

namespace Zoho_Migration.ZOHO.Projects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Project
    {
        [JsonPropertyName("is_strict")]
        public string IsStrict { get; set; }

        [JsonPropertyName("bug_count")]
        public BugCount BugCount { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        [JsonPropertyName("bug_client_permission")]
        public string BugClientPermission { get; set; }

        [JsonPropertyName("taskbug_prefix")]
        public string TaskbugPrefix { get; set; }

        [JsonPropertyName("start_date_long")]
        public long StartDateLong { get; set; }

        [JsonPropertyName("updated_date_long")]
        public long UpdatedDateLong { get; set; }

        [JsonPropertyName("show_project_overview")]
        public bool ShowProjectOverview { get; set; }

        [JsonPropertyName("task_count")]
        public TaskCount TaskCount { get; set; }

        [JsonPropertyName("updated_date_format")]
        public string UpdatedDateFormat { get; set; }

        [JsonPropertyName("bug_defaultview")]
        public string BugDefaultview { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_chat_enabled")]
        public bool IsChatEnabled { get; set; }

        [JsonPropertyName("is_sprints_project")]
        public bool IsSprintsProject { get; set; }

        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        [JsonPropertyName("created_date_long")]
        public long CreatedDateLong { get; set; }

        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("created_date_format")]
        public string CreatedDateFormat { get; set; }

        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; set; }

        [JsonPropertyName("profile_id")]
        public long ProfileId { get; set; }

        [JsonPropertyName("is_webtab_available")]
        public bool IsWebtabAvailable { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonPropertyName("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonPropertyName("created_by_id")]
        public string CreatedById { get; set; }

        [JsonPropertyName("updated_by_zpuid")]
        public long UpdatedByZpuid { get; set; }

        [JsonPropertyName("bug_prefix")]
        public string BugPrefix { get; set; }

        [JsonPropertyName("task_defaultview")]
        public TaskDefaultview TaskDefaultview { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        [JsonPropertyName("none_milestone_id")]
        public string NoneMilestoneId { get; set; }

        [JsonPropertyName("project_percent")]
        public string ProjectPercent { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("IS_BUG_ENABLED")]
        public bool IsBugEnabled { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("created_by_zpuid")]
        public long CreatedByZpuid { get; set; }

        [JsonPropertyName("custom_status_id")]
        public string CustomStatusId { get; set; }

        [JsonPropertyName("milestone_count")]
        public MilestoneCount MilestoneCount { get; set; }

        [JsonPropertyName("end_date_long")]
        public long EndDateLong { get; set; }

        [JsonPropertyName("custom_status_name")]
        public string CustomStatusName { get; set; }

        [JsonPropertyName("owner_zpuid")]
        public string OwnerZpuid { get; set; }

        [JsonPropertyName("is_client_assign_bug")]
        public string IsClientAssignBug { get; set; }

        [JsonPropertyName("billing_status")]
        public string BillingStatus { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonPropertyName("custom_status_color")]
        public string CustomStatusColor { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("enabled_tabs")]
        public List<string> EnabledTabs { get; set; }

        [JsonPropertyName("is_public")]
        public string IsPublic { get; set; }

        [JsonPropertyName("id_string")]
        public string IdString { get; set; }

        [JsonPropertyName("created_date")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("updated_date")]
        public string UpdatedDate { get; set; }

        [JsonPropertyName("cascade_setting")]
        public CascadeSetting CascadeSetting { get; set; }

        [JsonPropertyName("layout_details")]
        public LayoutDetails LayoutDetails { get; set; }
    }

    public class BugCount
    {
        [JsonPropertyName("closed")]
        public int Closed { get; set; }

        [JsonPropertyName("open")]
        public int Open { get; set; }
    }

    public class TaskCount
    {
        [JsonPropertyName("closed")]
        public int Closed { get; set; }

        [JsonPropertyName("open")]
        public int Open { get; set; }
    }

    public class TaskDefaultview
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("activity")]
        public Url Activity { get; set; }

        [JsonPropertyName("document")]
        public Url Document { get; set; }

        [JsonPropertyName("forum")]
        public Url Forum { get; set; }

        [JsonPropertyName("timesheet")]
        public Url Timesheet { get; set; }

        [JsonPropertyName("task")]
        public Url Task { get; set; }

        [JsonPropertyName("folder")]
        public Url Folder { get; set; }

        [JsonPropertyName("milestone")]
        public Url Milestone { get; set; }

        [JsonPropertyName("bug")]
        public Url Bug { get; set; }

        [JsonPropertyName("self")]
        public Url Self { get; set; }

        [JsonPropertyName("tasklist")]
        public Url Tasklist { get; set; }

        [JsonPropertyName("event")]
        public Url Event { get; set; }

        [JsonPropertyName("user")]
        public Url User { get; set; }

        [JsonPropertyName("status")]
        public Url Status { get; set; }
    }

    public class Url
    {
        [JsonPropertyName("url")]
        public string UrlValue { get; set; }
    }

    public class MilestoneCount
    {
        [JsonPropertyName("closed")]
        public dynamic Closed { get; set; }

        [JsonPropertyName("open")]
        public dynamic Open { get; set; }
    }

    public class CascadeSetting
    {
        [JsonPropertyName("date")]
        public bool Date { get; set; }

        [JsonPropertyName("logHours")]
        public bool LogHours { get; set; }

        [JsonPropertyName("plan")]
        public bool Plan { get; set; }

        [JsonPropertyName("percentage")]
        public bool Percentage { get; set; }

        [JsonPropertyName("workHours")]
        public bool WorkHours { get; set; }
    }

    public class LayoutDetails
    {
        [JsonPropertyName("task")]
        public Layout Task { get; set; }

        [JsonPropertyName("bug")]
        public Layout Bug { get; set; }

        [JsonPropertyName("project")]
        public Layout Project { get; set; }
    }

    public class Layout
    {
        [JsonPropertyName("is_private")]
        public bool IsPrivate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

   }
