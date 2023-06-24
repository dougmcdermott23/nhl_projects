using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class GameType
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = String.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = String.Empty;

    [JsonPropertyName("postseason")]
    public bool? Postseason { get; set; }
}
