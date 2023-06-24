using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed;

public class LiveFeedMetaData
{
    [JsonPropertyName("wait")]
    public int? Wait { get; set; }

    [JsonPropertyName("timeStamp")]
    public string TimeStamp { get; set; } = string.Empty;
}
