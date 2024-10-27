using Newtonsoft.Json;
using System.Text.Json;
using Zoho_Migration.Git_Ignore;
using Zoho_Migration.ZOHO.TimeSheet;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Zoho_Migration.ZOHO.User
{
    public class UserMapper
    {
        String path = "C:\\Users\\TE-66\\source\\repos\\Zoho_Migration\\Zoho_Migration\\ZOHO\\User\\user.json";

        //public UserMapper()
        //{
        //    string jsonResponse = File.ReadAllText(path);
        //    dynamic response = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

        //    if (response != null)
        //    {
        //        dynamic timelogdata = response;
        //        UsersResponse projecttask = dataMapper(timelogdata.ToString());
        //    }
        //    else
        //    {
        //        throw new Exception("User data or File not found: ");
        //    }
        //}
        public static async Task<UsersResponse> dataMapper(string url)
        {
            string token = Client_Cred.code;
            NetworkServices _networkServices = new NetworkServices(token);
            dynamic data = await _networkServices.GetAsync<dynamic>(url);
            dynamic response = JsonConvert.DeserializeObject(data.ToString());

            // Deserialize the JSON string into UsersResponse object
            UsersResponse usersResponse = JsonSerializer.Deserialize<UsersResponse>(response.ToString());

            // Accessing properties
            if (usersResponse != null)
            {
                //foreach (var user in usersResponse.Users)
                //{
                //    Console.WriteLine("Name: " + user.Name);
                //    Console.WriteLine("Email: " + user.Email);
                //    Console.WriteLine("Role: " + user.Role);
                //    Console.WriteLine("Portal Role: " + user.PortalRoleName);
                //    Console.WriteLine("Is Active: " + user.Active);
                //    Console.WriteLine();
                //}
            }
            return usersResponse;
        }
    }
}
