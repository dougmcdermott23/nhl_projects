using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Stats;

public class GameType
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("postseason")]
    public bool? Postseason { get; set; }
}
