using System.Net.Http.Json;

namespace Data.Http.NHL;

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
}