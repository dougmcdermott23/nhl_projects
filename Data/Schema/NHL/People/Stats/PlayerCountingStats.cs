using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public partial class PlayerCountingStats
{
    [JsonPropertyName("timeOnIce")]
    public string TimeOnIce { get; set; } = String.Empty;

    [JsonPropertyName("timeOnIcePerGame")]
    public string TimeOnIcePerGame { get; set; } = String.Empty;

    #region Skater Stats

    [JsonPropertyName("assists")]
    public int? Assists { get; set; }

    [JsonPropertyName("goals")]
    public int? Goals { get; set; }

    [JsonPropertyName("pim")]
    public int? Pim { get; set; }

    [JsonPropertyName("games")]
    public int? Games { get; set; }

    [JsonPropertyName("powerPlayTimeOnIce")]
    public string PowerPlayTimeOnIce { get; set; } = String.Empty;

    [JsonPropertyName("evenTimeOnIce")]
    public string EvenTimeOnIce { get; set; } = String.Empty;

    [JsonPropertyName("penaltyMinutes")]
    public int? PenaltyMinutes { get; set; }

    [JsonPropertyName("faceOffPct")]
    public double? FaceOffPct { get; set; }

    [JsonPropertyName("shortHandedTimeOnIce")]
    public string ShortHandedTimeOnIce { get; set; } = String.Empty;

    [JsonPropertyName("points")]
    public int? Points { get; set; }

    [JsonPropertyName("shifts")]
    public int? Shifts { get; set; }

    [JsonPropertyName("shots")]
    public int? Shots { get; set; }

    [JsonPropertyName("hits")]
    public int? Hits { get; set; }

    [JsonPropertyName("powerPlayGoals")]
    public int? PowerPlayGoals { get; set; }

    [JsonPropertyName("powerPlayPoints")]
    public int? PowerPlayPoints { get; set; }

    [JsonPropertyName("shotPct")]
    public double? ShotPct { get; set; }

    [JsonPropertyName("gameWinningGoals")]
    public int? GameWinningGoals { get; set; }

    [JsonPropertyName("overTimeGoals")]
    public int? OverTimeGoals { get; set; }

    [JsonPropertyName("shortHandedGoals")]
    public int? ShortHandedGoals { get; set; }

    [JsonPropertyName("shortHandedPoints")]
    public int? ShortHandedPoints { get; set; }

    [JsonPropertyName("blocked")]
    public int? Blocked { get; set; }

    [JsonPropertyName("plusMinus")]
    public int? PlusMinus { get; set; }

    #endregion

    #region Skater Stats Per Game

    [JsonPropertyName("evenTimeOnIcePerGame")]
    public string EvenTimeOnIcePerGame { get; set; } = String.Empty;

    [JsonPropertyName("shortHandedTimeOnIcePerGame")]
    public string ShortHandedTimeOnIcePerGame { get; set; } = String.Empty;

    [JsonPropertyName("powerPlayTimeOnIcePerGame")]
    public string PowerPlayTimeOnIcePerGame { get; set; } = String.Empty;

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

    [JsonPropertyName("ot")]
    public int? Ot { get; set; }

    [JsonPropertyName("shutouts")]
    public int? Shutouts { get; set; }

    [JsonPropertyName("ties")]
    public int? Ties { get; set; }

    [JsonPropertyName("wins")]
    public int? Wins { get; set; }

    [JsonPropertyName("losses")]
    public int? Losses { get; set; }

    [JsonPropertyName("saves")]
    public int? Saves { get; set; }

    [JsonPropertyName("powerPlaySaves")]
    public int? PowerPlaySaves { get; set; }

    [JsonPropertyName("shortHandedSaves")]
    public int? ShortHandedSaves { get; set; }

    [JsonPropertyName("evenSaves")]
    public int? EvenSaves { get; set; }

    [JsonPropertyName("shortHandedShots")]
    public int? ShortHandedShots { get; set; }

    [JsonPropertyName("evenShots")]
    public int? EvenShots { get; set; }

    [JsonPropertyName("powerPlayShots")]
    public int? PowerPlayShots { get; set; }

    [JsonPropertyName("savePercentage")]
    public double? SavePercentage { get; set; }

    [JsonPropertyName("goalAgainstAverage")]
    public double? GoalAgainstAverage { get; set; }

    [JsonPropertyName("gamesStarted")]
    public int? GamesStarted { get; set; }

    [JsonPropertyName("shotsAgainst")]
    public int? ShotsAgainst { get; set; }

    [JsonPropertyName("goalsAgainst")]
    public int? GoalsAgainst { get; set; }

    [JsonPropertyName("powerPlaySavePercentage")]
    public double? PowerPlaySavePercentage { get; set; }

    [JsonPropertyName("shortHandedSavePercentage")]
    public double? ShortHandedSavePercentage { get; set; }

    [JsonPropertyName("evenStrengthSavePercentage")]
    public double? EvenStrengthSavePercentage { get; set; }

    #endregion
}
