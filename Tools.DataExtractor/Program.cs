using System.Net.Http.Headers;

namespace Tools.StockMarket;

using Data.Schema.NHL;
using Data.Schema.NHL.Game.LiveFeed;

using static Data.Http.NHL.QueryUtils;
using static Data.Schema.NHL.EndPoints;

public static class StockMarket
{
    private static HttpClient Client = new();

    static void Main()
    {
        RunAsync().GetAwaiter().GetResult();
    }

    private static async Task RunAsync()
    {
        using var client = new HttpClient();

        client.BaseAddress = new Uri(BaseUrl);

        client.DefaultRequestHeaders.Accept.Clear();

        client.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var endpoint = String.Format(EndPoints.GameLiveFeed, 2022021000);

        if (!Uri.TryCreate(client.BaseAddress, endpoint, out var uri))
        {
            throw new ArgumentException();
        }

        var liveFeed = await Client.GetValueAsync<LiveFeed>(uri.ToString());
    }
}