using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Standings;

public class Streak
{
    [JsonPropertyName("streakType")]
    public string StreakType { get; set; } = String.Empty;

    [JsonPropertyName("streakNumber")]
    public int? StreakNumber { get; set; }

    [JsonPropertyName("streakCode")]
    public string StreakCode { get; set; } = String.Empty;
}
