using Data.Schema.NHL.Teams;
using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays.Play;

public class About
{
    [JsonPropertyName("eventIdx")]
    public int? EventIdx { get; set; }

    [JsonPropertyName("eventId")]
    public int? EventId { get; set; }

    [JsonPropertyName("period")]
    public int? Period { get; set; }

    [JsonPropertyName("periodType")]
    public string PeriodType { get; set; } = string.Empty;

    [JsonPropertyName("ordinalNum")]
    public string OrdinalNum { get; set; } = string.Empty;

    [JsonPropertyName("periodTime")]
    public string PeriodTime { get; set; } = string.Empty;

    [JsonPropertyName("periodTimeRemaining")]
    public string PeriodTimeRemaining { get; set; } = string.Empty;

    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }

    [JsonPropertyName("goals")]
    public Matchup<int>? Goals { get; set; }
}
