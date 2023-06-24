using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Stats;

public class StatType
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("gameType")]
    public GameType? GameType { get; set; }
}
