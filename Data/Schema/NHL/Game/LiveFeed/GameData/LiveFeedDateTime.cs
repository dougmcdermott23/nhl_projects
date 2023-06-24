using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.GameData;

public class LiveFeedDateTime
{
    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }

    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }
}
