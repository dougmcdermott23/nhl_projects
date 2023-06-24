using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LineScore;

using Teams;

public class LineScoreTeam
{
    [JsonPropertyName("goals")]
    public int? Goals { get; set; }

    [JsonPropertyName("shotsOnGoal")]
    public int? ShotsOnGoal { get; set; }

    [JsonPropertyName("rinkSide")]
    public string RinkSide { get; set; } = string.Empty;

    [JsonPropertyName("scores")]
    public int? Scores { get; set; }

    [JsonPropertyName("attempts")]
    public int? Attempts { get; set; }

    [JsonPropertyName("team")]
    public Team? Team { get; set; }

    [JsonPropertyName("goaliePulled")]
    public bool? GoaliePulled { get; set; }

    [JsonPropertyName("numSkaters")]
    public int? NumSkaters { get; set; }

    [JsonPropertyName("powerPlay")]
    public bool? PowerPlay { get; set; }
}