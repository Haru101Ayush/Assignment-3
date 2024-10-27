using System;
using System.Text.Json;
using Zoho_Migration.AUTH;
using Zoho_Migration.Git_Ignore;
using Zoho_Migration.ZOHO.Projects;
using Zoho_Migration.ZOHO.Tasks;
using Zoho_Migration.ZOHO.Tasks.Task_Comments;
using Zoho_Migration.ZOHO.TimeSheet;
using Zoho_Migration.ZOHO.User;

namespace Zoho_Migration.NativePMS
{
    public class Executer
    {
        Project project = new Project();
        ProjectPMS projectPMS = new ProjectPMS();
        DataObjects zohoproject = new DataObjects();
        TaskMapper taskMapper = new TaskMapper();

        public Executer() {
            //RequestProject asd = new RequestProject();
            //asd.GetProjets();

            //new DataObjects();

            //new TaskMapper();

            //new TimeSheetMapper();

            //new UserMapper();

            //var auth = new TokenAuth();
            //var ans = auth.TokenAsync();

            Mapper();
        }

        public async void Mapper()
        {
            project = await zohoproject.GetProjets();
            var tasksTask = taskMapper.GetTasks(project.Link.Task.UrlValue);
            var userTask = UserMapper.dataMapper(project.Link.User.UrlValue);

            var tasks = await tasksTask;
            var user = await userTask;

            projectPMS.Name = project.Name;
            projectPMS.Id = project.Id;
            projectPMS.Description = "NA";
            projectPMS.StartDate = project.StartDate;
            projectPMS.EndDate = project.EndDate;
            projectPMS.Status = project.Status;
            projectPMS.Priority = "N|A";

            Console.WriteLine(project.OwnerId);

            projectPMS.Owner = new()
            {
                Name = project.OwnerName,
                Id = project.OwnerId,
                Email = project.OwnerEmail
            };

            // Handling Resources
            projectPMS.Resources = user.Users?.Select(resource => new Resource
            {
                Id = resource.Id,
                Name = resource.Name,
                Email = resource.Email,
                Role = resource.Role,
                Permissions = "no data from api"
            }).ToList() ?? new List<Resource>();

            // Handling Tasks
            if (tasks != null)
            {
                var taskList = new List<Task>();

                foreach (var task in tasks)
                {
                    if (task.Subtasks) {
                        Console.WriteLine("SubTask Found ---------------------------------------------------------------");
                        var subtasks = await SubTaskMapper(task.Link.Subtask?.UrlValue ?? string.Empty);
                        taskList.Add(new Task
                        {
                            Id = task.Id,
                            Title = task.Name,
                            Status = task.Status,
                            StartDate = task.StartDate,
                            Priority = task.Priority,
                            DueDate = task.EndDate,
                            TimeEstimate = task.Duration,
                            TimeSpent = task.LogHours,
                            Description = task.Description,
                            Type = task.BillingType,
                            Resolution = "N|A",
                            Subtasks = subtasks,
                            Comments = new List<Comment>(),
                            Reporter = new Reporter { Id = "N|A", Name = "N|A", Email = "N|A" }
                        });
                    }
                    else
                    {
                        taskList.Add(new Task
                        {
                            Id = task.Id,
                            Title = task.Name,
                            Status = task.Status,
                            StartDate = task.StartDate,
                            Priority = task.Priority,
                            DueDate = task.EndDate,
                            TimeEstimate = task.Duration,
                            TimeSpent = task.LogHours,
                            Description = task.Description,
                            Type = task.BillingType,
                            Resolution = "N|A",
                            Comments = new List<Comment>(),
                            Reporter = new Reporter { Id = "N|A", Name = "N|A", Email = "N|A" }
                        }); }
                }
                projectPMS.Tasks = taskList;
            }
            else
            {
                projectPMS.Tasks = new List<Task>();
            }

            Display(projectPMS);
        }

        private async Task<List<Timelog>> TimeSheet_Mapper(string urlValue)
        {
            var timelogs = await TimeSheetMapper.dataMapper(urlValue);
            return timelogs.TaskLogs.Select(tl => new Timelog
            {
                Id = tl.Id,
                DateLogged = tl.LogDate,
                TimeSpent = tl.HoursDisplay,
                User = new User { Id = tl.OwnerId, Name = tl.OwnerName, Email = "N|A" },
            }).ToList();
        }

        private List<string> TagMapper(List<Tag> tags)
        {
            return tags?.Select(t => t.Name.ToString()).ToList() ?? new List<string>();
        }

        private IEnumerable<Assignee> TaskMapper(IEnumerable<Following_User> Users) => Users?.Select(user => new Assignee
        {
            Id = user.FOLLOWERID,
            Name = user.FNAME,
            Email = "N|A",
        }) ?? Enumerable.Empty<Assignee>();

        private async Task<List<Subtask>> SubTaskMapper(string url)
        {
            var token = Client_Cred.code;
            var json = await new NetworkServices(token).GetAsync<string>(url);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<SubTasklist>(json);
            return response.Tasks.Select(subtask => new Subtask
            {
                Id = subtask.Id,
                Title = subtask.Name,
                Status = subtask.Status,
                Assignees = (List<Assignee>)TaskMapper(subtask.TaskFollowers.Followers),
            }).ToList();
        }

        private void Display(ProjectPMS PMS)
        {
            Console.WriteLine("\n");
            Console.WriteLine("The Mapping has ended");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("The Mapping output is: ");
            Console.WriteLine("\n\n");
            Console.WriteLine(JsonSerializer.Serialize(PMS));
        }
    }
}
