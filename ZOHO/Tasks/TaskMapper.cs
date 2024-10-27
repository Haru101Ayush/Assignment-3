using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using Zoho_Migration.AUTH;
using Zoho_Migration.Git_Ignore;
using Zoho_Migration.ZOHO.Projects;
using Zoho_Migration.ZOHO.TimeSheet;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Zoho_Migration.ZOHO.Tasks
{
    public class TaskMapper
    {   
         List<Project_Task> tasks = new List<Project_Task>();
        TokenAuth auth = new TokenAuth();
        
        
        //public TaskMapper()
        //{
        //    string path = "C:\\Users\\TE-66\\source\\repos\\Zoho_Migration\\Zoho_Migration\\ZOHO\\Tasks\\TaskResponse.json";

        //    string jsonResponse = File.ReadAllText(path);
        //    dynamic response = JsonConvert.DeserializeObject(jsonResponse);

        //    if (response["tasks"] != null && response != null)
        //    {
        //        //dynamic taskdata = response["tasks"][0];
        //        //Project_Task projecttask = dataMapper(taskdata.ToString());

        //        dynamic taskdata = response["tasks"];

        //        foreach (var task in taskdata)
        //        {
        //            tasks.Add(dataMapper(task.ToString()));
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Bad data or File not found: " + path);
        //    }
        //    //if (response["projects"] != null) 
        //    //{ datamapper(response); }

        //}


        public async Task<List<Project_Task>> GetTasks(string url)
        {

            string token = Client_Cred.code;
            NetworkServices _networkServices = new NetworkServices(token);
            dynamic data = await _networkServices.GetAsync<dynamic>(url);
            dynamic response = JsonConvert.DeserializeObject(data.ToString());

            if (response["tasks"] != null && response != null)
            {
                dynamic taskdata = response["tasks"];

                foreach (var task in taskdata)
                {
                    tasks.Add(DataMapper(task.ToString()));
                }
                return tasks;
            }
            else
            {
                throw new Exception("Bad data");
            }

        }

        public  Project_Task DataMapper(string data)
        {

            Project_Task taskDetails = JsonSerializer.Deserialize<Project_Task>(data);

                //// Accessing properties
                //if (taskDetails != null)
                //{
                //    Console.WriteLine("Task Name: " + taskDetails.Name);
                //    Console.WriteLine("Start Date: " + taskDetails.StartDate);
                //    Console.WriteLine("Owner Name: " + taskDetails.Details.Owners[0].FullName);
                //    Console.WriteLine("Priority: " + taskDetails.Priority);
                //    Console.WriteLine("subtasks : " + taskDetails.Subtasks);
                //    Console.WriteLine("Status: " + taskDetails.Status.Name);
                //    Console.WriteLine("Percent Complete: " + taskDetails.PercentComplete);
                //    Console.WriteLine("Timesheet URL: " + taskDetails.Link.Timesheet.UrlValue);
                //    Console.WriteLine("\n\n");
                //}

            return taskDetails;
        }
    }
}
