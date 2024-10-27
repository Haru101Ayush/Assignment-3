using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zoho_Migration.NativePMS
{
    public class ProjectPMS
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("description")]
        public dynamic Description { get; set; }

        [JsonPropertyName("startDate")]
        public dynamic StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public dynamic EndDate { get; set; }

        [JsonPropertyName("status")]
        public dynamic Status { get; set; }

        [JsonPropertyName("priority")]
        public dynamic Priority { get; set; }

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("tags")]
        public List<dynamic> Tags { get; set; }

        [JsonPropertyName("customFields")]
        public Dictionary<dynamic, dynamic> CustomFields { get; set; }

        [JsonPropertyName("tasks")]
        public List<Task> Tasks { get; set; }

        [JsonPropertyName("resources")]
        public List<Resource> Resources { get; set; }
    }
    //new Owner
    public class Owner
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

    public class Task
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("title")]
        public dynamic Title { get; set; }

        [JsonPropertyName("description")]
        public dynamic Description { get; set; }

        [JsonPropertyName("type")]
        public dynamic Type { get; set; }

        [JsonPropertyName("status")]
        public dynamic Status { get; set; }

        [JsonPropertyName("assignees")]
        public List<Assignee> Assignees { get; set; }

        [JsonPropertyName("reporter")]
        public Reporter Reporter { get; set; }

        [JsonPropertyName("priority")]
        public dynamic Priority { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("startDate")]
        public dynamic StartDate { get; set; }

        [JsonPropertyName("dueDate")]
        public dynamic DueDate { get; set; }

        [JsonPropertyName("timeEstimate")]
        public dynamic TimeEstimate { get; set; }

        [JsonPropertyName("timeSpent")]
        public dynamic TimeSpent { get; set; }

        [JsonPropertyName("resolution")]
        public dynamic Resolution { get; set; }

        [JsonPropertyName("subtasks")]
        public List<Subtask> Subtasks { get; set; }

        [JsonPropertyName("comments")]
        public List<Comment> Comments { get; set; }

        [JsonPropertyName("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonPropertyName("timelogs")]
        public List<Timelog> Timelogs { get; set; }

        [JsonPropertyName("customFields")]
        public Dictionary<dynamic, dynamic> CustomFields { get; set; }
    }

    public class Assignee
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("email")]
        public dynamic Email { get; set; }
    }

    public class Reporter
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("email")]
        public dynamic Email { get; set; }
    }

    public class Subtask
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("title")]
        public dynamic Title { get; set; }

        [JsonPropertyName("status")]
        public dynamic Status { get; set; }

        [JsonPropertyName("assignees")]
        public List<Assignee> Assignees { get; set; }
    }

    public class Comment
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonPropertyName("text")]
        public dynamic Text { get; set; }

        [JsonPropertyName("timestamp")]
        public dynamic Timestamp { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("email")]
        public dynamic Email { get; set; }
    }

    public class Attachment
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("fileName")]
        public dynamic FileName { get; set; }

        [JsonPropertyName("fileType")]
        public dynamic FileType { get; set; }

        [JsonPropertyName("fileSize")]
        public dynamic FileSize { get; set; }

        [JsonPropertyName("uploadDate")]
        public dynamic UploadDate { get; set; }

        [JsonPropertyName("url")]
        public dynamic Url { get; set; }
    }

    public class Timelog
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("timeSpent")]
        public dynamic TimeSpent { get; set; }

        [JsonPropertyName("dateLogged")]
        public dynamic DateLogged { get; set; }
    }

    public class User
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("email")]
        public dynamic Email { get; set; }
    }

    public class Resource
    {
        [JsonPropertyName("id")]
        public dynamic Id { get; set; }

        [JsonPropertyName("name")]
        public dynamic Name { get; set; }

        [JsonPropertyName("email")]
        public dynamic Email { get; set; }

        [JsonPropertyName("role")]
        public dynamic Role { get; set; }

        [JsonPropertyName("permissions")]
        public dynamic Permissions { get; set; }
    }

}
