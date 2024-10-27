using Newtonsoft.Json;
using System;
using System.Text.Json;
using Zoho_Migration.Git_Ignore;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Zoho_Migration.ZOHO.TimeSheet
{
    public class TimeSheetMapper
    {
        //public TimeSheetMapper()
        //{
        //    string path = "C:\\Users\\TE-66\\source\\repos\\Zoho_Migration\\Zoho_Migration\\ZOHO\\TimeSheet\\timesheet.json";

        //    string jsonResponse = File.ReadAllText(path);
        //    dynamic response = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

        //    if (response["timelogs"] != null && response != null)
        //    {
        //        dynamic timelogdata = response["timelogs"];
        //        Timelogs projecttask = dataMapper(timelogdata.ToString());
        //    }
        //    else
        //    {
        //        throw new Exception("Bad data or File not found: " + path);
        //    }

        //}


        public static async Task<Timelogs> dataMapper(string url)
        {
            string token = Client_Cred.code;
            NetworkServices _networkServices = new NetworkServices(token);
            dynamic data = await _networkServices.GetAsync<dynamic>(url);
            dynamic response = JsonConvert.DeserializeObject(data.ToString());

            // Deserialize the JSON string into Timelogs object
            Timelogs timelogs = JsonSerializer.Deserialize<Timelogs>(response.ToString());

            // Accessing properties
            if (timelogs != null)
            {
                Console.WriteLine("Total Log Hours: " + timelogs.TotalLogHours);
                foreach (var taskLog in timelogs.TaskLogs)
                {
                    //Console.WriteLine("Task Name: " + taskLog.Task.Name);
                    //Console.WriteLine("Owner Name: " + taskLog.OwnerName);
                    //Console.WriteLine("Log Date: " + taskLog.LogDate);
                    //Console.WriteLine("Hours: " + taskLog.Hours);
                    //Console.WriteLine("Task Log URL: " + taskLog.Link.Self.UrlValue);
                }
            }
            return timelogs;
        }

    }
}
