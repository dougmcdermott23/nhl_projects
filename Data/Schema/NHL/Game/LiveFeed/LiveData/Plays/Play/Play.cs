using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays.Play;

using People;
using Teams;

public class Play
{
    [JsonPropertyName("result")]
    public Result? Result { get; set; }

    [JsonPropertyName("about")]
    public About? About { get; set; }

    [JsonPropertyName("coordinates")]
    public Coordinates? Coordinates { get; set; }

    [JsonPropertyName("players")]
    public List<Player> Players { get; set; } = new();

    [JsonPropertyName("team")]
    public Team? Team { get; set; }
}
