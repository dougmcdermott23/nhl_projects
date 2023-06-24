using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class TeamSplit
{
    [JsonPropertyName("stat")]
    public TeamSeasonStats? Stat { get; set; }

    [JsonPropertyName("team")]
    public Team? Team { get; set; }
}
