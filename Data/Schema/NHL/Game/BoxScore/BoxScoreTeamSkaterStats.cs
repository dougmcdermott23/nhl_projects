using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.BoxScore;

public class BoxScoreTeamSkaterStats
{
    [JsonPropertyName("goals")]
    public int? Goals { get; set; }

    [JsonPropertyName("pim")]
    public int? Pim { get; set; }

    [JsonPropertyName("shots")]
    public int? Shots { get; set; }

    [JsonPropertyName("powerPlayPercentage")]
    public string PowerPlayPercentage { get; set; } = string.Empty;

    [JsonPropertyName("powerPlayGoals")]
    public double? PowerPlayGoals { get; set; }

    [JsonPropertyName("powerPlayOpportunities")]
    public double? PowerPlayOpportunities { get; set; }

    [JsonPropertyName("faceOffWinPercentage")]
    public string FaceOffWinPercentage { get; set; } = string.Empty;

    [JsonPropertyName("blocked")]
    public int? Blocked { get; set; }

    [JsonPropertyName("takeaways")]
    public int? Takeaways { get; set; }

    [JsonPropertyName("giveaways")]
    public int? Giveaways { get; set; }

    [JsonPropertyName("hits")]
    public int? Hits { get; set; }
}
