using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public partial class PlayerCountingStatsRankings
{
    #region Skater Stats

    [JsonPropertyName("rankPowerPlayGoals")]
    public string RankPowerPlayGoals { get; set; } = String.Empty;

    [JsonPropertyName("rankBlockedShots")]
    public string RankBlockedShots { get; set; } = String.Empty;

    [JsonPropertyName("rankAssists")]
    public string RankAssists { get; set; } = String.Empty;

    [JsonPropertyName("rankShotPct")]
    public string RankShotPct { get; set; } = String.Empty;

    [JsonPropertyName("rankGoals")]
    public string RankGoals { get; set; } = String.Empty;

    [JsonPropertyName("rankHits")]
    public string RankHits { get; set; } = String.Empty;

    [JsonPropertyName("rankPenaltyMinutes")]
    public string RankPenaltyMinutes { get; set; } = String.Empty;

    [JsonPropertyName("rankShortHandedGoals")]
    public string RankShortHandedGoals { get; set; } = String.Empty;

    [JsonPropertyName("rankPlusMinus")]
    public string RankPlusMinus { get; set; } = String.Empty;

    [JsonPropertyName("rankShots")]
    public string RankShots { get; set; } = String.Empty;

    [JsonPropertyName("rankPoints")]
    public string RankPoints { get; set; } = String.Empty;

    [JsonPropertyName("rankOvertimeGoals")]
    public string RankOvertimeGoals { get; set; } = String.Empty;

    [JsonPropertyName("rankGamesPlayed")]
    public string RankGamesPlayed { get; set; } = String.Empty;

    #endregion

    #region Goalie Stats

    [JsonPropertyName("shotsAgainst")]
    public string ShotsAgainst { get; set; } = String.Empty;

    [JsonPropertyName("ot")]
    public string Ot { get; set; } = String.Empty;

    [JsonPropertyName("penaltyMinutes")]
    public string PenaltyMinutes { get; set; } = String.Empty;

    [JsonPropertyName("timeOnIce")]
    public string TimeOnIce { get; set; } = String.Empty;

    [JsonPropertyName("shutOuts")]
    public string ShutOuts { get; set; } = String.Empty;

    [JsonPropertyName("saves")]
    public string Saves { get; set; } = String.Empty;

    [JsonPropertyName("losses")]
    public string Losses { get; set; } = String.Empty;

    [JsonPropertyName("goalsAgainst")]
    public string GoalsAgainst { get; set; } = String.Empty;

    [JsonPropertyName("savePercentage")]
    public string SavePercentage { get; set; } = String.Empty;

    [JsonPropertyName("games")]
    public string Games { get; set; } = String.Empty;

    [JsonPropertyName("goalsAgainstAverage")]
    public string GoalsAgainstAverage { get; set; } = String.Empty;

    [JsonPropertyName("wins")]
    public string Wins { get; set; } = String.Empty;

    #endregion
}
