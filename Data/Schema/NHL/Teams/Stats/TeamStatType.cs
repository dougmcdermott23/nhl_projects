using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class TeamStatType
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = String.Empty;

    [JsonPropertyName("gameType")]
    public GameType? GameType { get; set; }
}
