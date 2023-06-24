using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class TeamStats
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("stats")]
    public List<TeamStatsInfo> Stats { get; set; } = new();
}
