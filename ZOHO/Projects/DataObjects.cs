using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using Zoho_Migration.AUTH;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Zoho_Migration.ZOHO.Projects
{
    public class DataObjects
    {

        List<ProjectClass> projects = new List<ProjectClass>() {};
        NetworkServices _networkServices = new NetworkServices();
        private readonly string Project_Endpoint = "https://projectsapi.zoho.in";
        TokenAuth auth = new TokenAuth();

        public async Task<Project> GetProjets()
        {

            string token = await auth.TokenAsync();
            NetworkServices _networkServices = new NetworkServices(token);
            dynamic data = await _networkServices.GetAsync<dynamic>($"{Project_Endpoint}/restapi/portal/60033706418/projects/");
            dynamic response = JsonConvert.DeserializeObject(data.ToString());

            if (response["projects"] != null && response != null)
            {
                dynamic projectdata = response["projects"][0];
                Project project = ProjectMapper.MapJsonFileToProject(projectdata.ToString());
                Console.WriteLine("Requested Project Api WORKS :  " + project.Name);
                return project;
            }

            else
            {
                throw new Exception("Deserialization failed. The project object is null.");
            }
          
        }

        //public DataObjects()
        //{
        //    string path = "C:\\Users\\TE-66\\source\\repos\\Zoho_Migration\\Zoho_Migration\\ZOHO\\Projects\\allprojects.json";
        //    string projpath = "C:\\Users\\TE-66\\source\\repos\\Zoho_Migration\\Zoho_Migration\\ZOHO\\Projects\\projectdiscryption.json";

        //    string jsonResponse = File.ReadAllText(path);
        //    dynamic response = JsonConvert.DeserializeObject(jsonResponse);

        //    if (response["projects"] != null && response != null)
        //    {
        //        dynamic projectdata = response["projects"][0];
        //        Project project = ProjectMapper.MapJsonFileToProject(projectdata.ToString());

        //        if (project != null)
        //        {
        //            Console.WriteLine("Project Name: " + project.Name);
        //            Console.WriteLine("Owner: " + project.OwnerName);
        //            Console.WriteLine("Start Date: " + project.StartDate);
        //            Console.WriteLine("End Date: " + project.EndDate);
        //            Console.WriteLine("Status: " + project.Status);
        //            Console.WriteLine("Key: " + project.Key);

        //        }
        //        else
        //        {
        //            Console.WriteLine("Failed to map the JSON response to a Project object.");
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Bad data or File not found: " + path);
        //    }
        //    //if (response["projects"] != null) 
        //    //{ datamapper(response); }

        //}
    }
}
