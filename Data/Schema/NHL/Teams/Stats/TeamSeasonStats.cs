using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

public class TeamSeasonStats
{
    [JsonPropertyName("gamesPlayed")]
    public int? GamesPlayed { get; set; }

    [JsonPropertyName("wins")]
    public object Wins { get; set; } = String.Empty;

    [JsonPropertyName("losses")]
    public object Losses { get; set; } = String.Empty;

    [JsonPropertyName("ot")]
    public object Ot { get; set; } = String.Empty;

    [JsonPropertyName("pts")]
    public object Pts { get; set; } = String.Empty;

    [JsonPropertyName("ptPctg")]
    public string PtPctg { get; set; } = String.Empty;

    [JsonPropertyName("goalsPerGame")]
    public object GoalsPerGame { get; set; } = String.Empty;

    [JsonPropertyName("goalsAgainstPerGame")]
    public object GoalsAgainstPerGame { get; set; } = String.Empty;

    [JsonPropertyName("evGGARatio")]
    public object EvGGARatio { get; set; } = String.Empty;

    [JsonPropertyName("powerPlayPercentage")]
    public string PowerPlayPercentage { get; set; } = String.Empty;

    [JsonPropertyName("powerPlayGoals")]
    public object PowerPlayGoals { get; set; } = String.Empty;

    [JsonPropertyName("powerPlayGoalsAgainst")]
    public object PowerPlayGoalsAgainst { get; set; } = String.Empty;

    [JsonPropertyName("powerPlayOpportunities")]
    public object PowerPlayOpportunities { get; set; } = String.Empty;

    [JsonPropertyName("penaltyKillPercentage")]
    public string PenaltyKillPercentage { get; set; } = String.Empty;

    [JsonPropertyName("shotsPerGame")]
    public object ShotsPerGame { get; set; } = String.Empty;

    [JsonPropertyName("shotsAllowed")]
    public object ShotsAllowed { get; set; } = String.Empty;

    [JsonPropertyName("winScoreFirst")]
    public object WinScoreFirst { get; set; } = String.Empty;

    [JsonPropertyName("winOppScoreFirst")]
    public object WinOppScoreFirst { get; set; } = String.Empty;

    [JsonPropertyName("winLeadFirstPer")]
    public object WinLeadFirstPer { get; set; } = String.Empty;

    [JsonPropertyName("winLeadSecondPer")]
    public object WinLeadSecondPer { get; set; } = String.Empty;

    [JsonPropertyName("winOutshootOpp")]
    public object WinOutshootOpp { get; set; } = String.Empty;

    [JsonPropertyName("winOutshotByOpp")]
    public object WinOutshotByOpp { get; set; } = String.Empty;

    [JsonPropertyName("faceOffsTaken")]
    public object FaceOffsTaken { get; set; } = String.Empty;

    [JsonPropertyName("faceOffsWon")]
    public object FaceOffsWon { get; set; } = String.Empty;

    [JsonPropertyName("faceOffsLost")]
    public object FaceOffsLost { get; set; } = String.Empty;

    [JsonPropertyName("faceOffWinPercentage")]
    public string FaceOffWinPercentage { get; set; } = String.Empty;

    [JsonPropertyName("shootingPctg")]
    public double? ShootingPctg { get; set; }

    [JsonPropertyName("savePctg")]
    public double? SavePctg { get; set; }

    [JsonPropertyName("penaltyKillOpportunities")]
    public string PenaltyKillOpportunities { get; set; } = String.Empty;

    [JsonPropertyName("savePctRank")]
    public string SavePctRank { get; set; } = String.Empty;

    [JsonPropertyName("shootingPctRank")]
    public string ShootingPctRank { get; set; } = String.Empty;

}
