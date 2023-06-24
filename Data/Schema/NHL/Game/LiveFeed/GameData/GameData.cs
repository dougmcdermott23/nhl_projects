using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.GameData;

using People;
using Teams;
using Venues;

public class GameData
{
    [JsonPropertyName("game")]
    public Game? Game { get; set; }

    [JsonPropertyName("datetime")]
    public LiveFeedDateTime? Datetime { get; set; }

    [JsonPropertyName("status")]
    public LiveFeedStatus? Status { get; set; }

    [JsonPropertyName("teams")]
    public Matchup<Team>? Teams { get; set; }

    [JsonPropertyName("players")]
    public Dictionary<string, Person> Players { get; set; } = new();

    [JsonPropertyName("venue")]
    public Venue? Venue { get; set; }
}
