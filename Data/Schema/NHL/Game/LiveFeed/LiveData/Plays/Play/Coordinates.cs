using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays.Play;

public class Coordinates
{
    [JsonPropertyName("x")]
    public double? X { get; set; }

    [JsonPropertyName("y")]
    public double? Y { get; set; }
}
