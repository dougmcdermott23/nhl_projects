using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Data.Http.NHL;

using static Schema.NHL.EndPoints;

public static class QueryUtils
{
    public static async Task<T?> GetValueAsync<T>(this HttpClient client, string path)
    {
        T? value = default;

        var response = await client.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {
            value = await response.Content.ReadFromJsonAsync<T>();
        }

        return value;
    }

    public static async Task<T?> RunAsync<T>(string endPoint)
    {
        using var client = new HttpClient();

        client.BaseAddress = new Uri(BaseUrl);

        client.DefaultRequestHeaders.Accept.Clear();

        client.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));

        if (!Uri.TryCreate(client.BaseAddress, endPoint, out var uri))
        {
            throw new ArgumentException($"URI with end point {endPoint} was not successfully created.");
        }

        return await client.GetValueAsync<T>(uri.ToString());
    }
}