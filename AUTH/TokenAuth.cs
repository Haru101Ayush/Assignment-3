
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Zoho_Migration.Git_Ignore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zoho_Migration.AUTH
{
    public class TokenAuth
    {   
        public string token = "";
        public string refreshToken = "1000.d5f5789c9907c3f32042ef1f852e504f.587fe595970fd7968d7ad55883fe1b5f";
        public string client_id = Client_Cred.client_id;
        public string client_secret = Client_Cred.client_secret;
        private static readonly HttpClient _httpClient = new HttpClient();
        public async Task<string> TokenAsync() {
            var url = $"https://accounts.zoho.in/oauth/v2/token?refresh_token={refreshToken}&client_id={client_id}&client_secret={client_secret}&grant_type=refresh_token";
            try
            {
                // Create the POST request without content
                HttpResponseMessage response = await _httpClient.PostAsync(url, null);

                // Check the response status code
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("POST request was successful.");
                    var res =response.Content.ReadAsStringAsync();
                    var jsonDoc = JsonDocument.Parse(res.Result.ToString());
                    string access_token = jsonDoc.RootElement.GetProperty("access_token").ToString();
                    Client_Cred.code = access_token;
                    Console.WriteLine("Access Token: from credddd " +Client_Cred.code);
                    Console.WriteLine(access_token);
                    return access_token;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null;
        }
    }
}
