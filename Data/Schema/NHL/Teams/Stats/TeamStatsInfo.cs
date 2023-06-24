using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class TeamStatsInfo
{
    [JsonPropertyName("type")]
    public TeamStatType? Type { get; set; }

    [JsonPropertyName("splits")]
    public List<TeamSplit> Splits { get; set; } = new();
}
