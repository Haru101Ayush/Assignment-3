using System.Text.Json;
using Zoho_Migration.Git_Ignore;

namespace Zoho_Migration.ZOHO.Tasks.Task_Comments
{
    public class CommentMapper
    {
        public static async Task<CommentsResponse> Commentmapper(string url)
        {
            string token = Client_Cred.code;
            NetworkServices _networkServices = new NetworkServices(token);
            dynamic data = await _networkServices.GetAsync<dynamic>(url);
            dynamic response = Newtonsoft.Json.JsonConvert.DeserializeObject(data.ToString());

            // Deserialize the JSON string into CommentsResponse object
            CommentsResponse commentsResponse = JsonSerializer.Deserialize<CommentsResponse>(response.ToString());

            // Accessing properties
            if (commentsResponse != null)
            {
                //foreach (var comment in commentsResponse.Comments)
                //{
                //    Console.WriteLine("Added By: " + comment.AddedPerson);
                //    Console.WriteLine("Content: " + comment.Content);
                //    Console.WriteLine("Project Name: " + comment.Project.Name);
                //    Console.WriteLine("Created Time: " + comment.CreatedTime);
                //    Console.WriteLine("Last Modified Time: " + comment.LastModifiedTime);
                //}
                return commentsResponse;
            }
            else
            {
                throw new Exception("CommentsResponse is null");
            }
        }
    }
}
