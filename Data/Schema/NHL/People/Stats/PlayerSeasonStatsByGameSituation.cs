using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public partial class PlayerSeasonStatsByGameSituation
{
    [JsonPropertyName("goalsInFirstPeriod")]
    public int? GoalsInFirstPeriod { get; set; }

    [JsonPropertyName("goalsInSecondPeriod")]
    public int? GoalsInSecondPeriod { get; set; }

    [JsonPropertyName("goalsInThirdPeriod")]
    public int? GoalsInThirdPeriod { get; set; }

    [JsonPropertyName("goalsInOvertime")]
    public int? GoalsInOvertime { get; set; }

    [JsonPropertyName("gameWinningGoals")]
    public int? GameWinningGoals { get; set; }

    [JsonPropertyName("emptyNetGoals")]
    public int? EmptyNetGoals { get; set; }

    [JsonPropertyName("shootOutGoals")]
    public int? ShootOutGoals { get; set; }

    [JsonPropertyName("shootOutShots")]
    public int? ShootOutShots { get; set; }

    [JsonPropertyName("goalsTrailingByOne")]
    public int? GoalsTrailingByOne { get; set; }

    [JsonPropertyName("goalsTrailingByTwo")]
    public int? GoalsTrailingByTwo { get; set; }

    [JsonPropertyName("goalsWhenTied")]
    public int? GoalsWhenTied { get; set; }

    [JsonPropertyName("goalsLeadingByOne")]
    public int? GoalsLeadingByOne { get; set; }

    [JsonPropertyName("goalsLeadingByTwo")]
    public int? GoalsLeadingByTwo { get; set; }

    [JsonPropertyName("goalsLeadingByThreePlus")]
    public int? GoalsLeadingByThreePlus { get; set; }

    [JsonPropertyName("penaltyGoals")]
    public int? PenaltyGoals { get; set; }

    [JsonPropertyName("penaltyShots")]
    public int? PenaltyShots { get; set; }

    [JsonPropertyName("goalsTrailingByThreePlus")]
    public int? GoalsTrailingByThreePlus { get; set; }
}
