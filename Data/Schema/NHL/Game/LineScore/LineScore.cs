using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LineScore;

using Teams;

public class LineScore
{
    [JsonPropertyName("currentPeriod")]
    public int? CurrentPeriod { get; set; }

    [JsonPropertyName("currentPeriodOrdinal")]
    public string CurrentPeriodOrdinal { get; set; } = String.Empty;

    [JsonPropertyName("currentPeriodTimeRemaining")]
    public string CurrentPeriodTimeRemaining { get; set; } = String.Empty;

    [JsonPropertyName("periods")]
    public List<LineScorePeriod> Periods { get; set; } = new();

    [JsonPropertyName("shootoutInfo")]
    public Matchup<LineScoreTeam>? ShootoutInfo { get; set; }

    [JsonPropertyName("teams")]
    public Matchup<LineScoreTeam>? Teams { get; set; }

    [JsonPropertyName("powerPlayStrength")]
    public string PowerPlayStrength { get; set; } = String.Empty;

    [JsonPropertyName("hasShootout")]
    public bool? HasShootout { get; set; }

    [JsonPropertyName("intermissionInfo")]
    public LineScoreIntermissionInfo? IntermissionInfo { get; set; }

    [JsonPropertyName("powerPlayInfo")]
    public LineScorePowerPlayInfo? PowerPlayInfo { get; set; }
}
