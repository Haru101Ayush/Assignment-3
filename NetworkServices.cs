using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class NetworkServices
{
    private readonly HttpClient _httpClient;

    public NetworkServices(string token = null)
    {
        _httpClient = new HttpClient();
        // Optional Authorization Header
        if (!string.IsNullOrEmpty(token))
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Zoho-oauthtoken", token);
    }

    private StringContent CreateJsonContent(object data)
    {
        return new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
    }

    private async Task<T> HandleResponse<T>(HttpResponseMessage response)
    {
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        try
        {
            var result = JsonSerializer.Deserialize<T>(json);
            return result;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            Console.WriteLine($"Invalid JSON: {json}");
            throw ex;
        }
        //return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<T> GetAsync<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        return await HandleResponse<T>(response);
    }

    public async Task<T> PostAsync<T>(string url, object data)
    {
        var response = await _httpClient.PostAsync(url, CreateJsonContent(data));
        return await HandleResponse<T>(response);
    }

    public async Task<T> PutAsync<T>(string url, object data)
    {
        var response = await _httpClient.PutAsync(url, CreateJsonContent(data));
        return await HandleResponse<T>(response);
    }

    public async Task DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
    }
}
