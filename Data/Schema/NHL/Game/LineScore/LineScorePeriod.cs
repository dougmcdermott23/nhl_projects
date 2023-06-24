using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LineScore;

public class LineScorePeriod
{
    [JsonPropertyName("periodType")]
    public string PeriodType { get; set; } = string.Empty;

    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    [JsonPropertyName("num")]
    public int? Num { get; set; }

    [JsonPropertyName("ordinalNum")]
    public string OrdinalNum { get; set; } = string.Empty;

    [JsonPropertyName("home")]
    public LineScoreTeam? Home { get; set; }

    [JsonPropertyName("away")]
    public LineScoreTeam? Away { get; set; }
}
