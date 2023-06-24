using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays.Play;

public class Result
{
    [JsonPropertyName("event")]
    public string Event { get; set; } = string.Empty;

    [JsonPropertyName("eventCode")]
    public string EventCode { get; set; } = string.Empty;

    [JsonPropertyName("eventTypeId")]
    public string EventTypeId { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("secondaryType")]
    public string SecondaryType { get; set; } = string.Empty;

    [JsonPropertyName("strength")]
    public Strength? Strength { get; set; }

    [JsonPropertyName("gameWinningGoal")]
    public bool? GameWinningGoal { get; set; }

    [JsonPropertyName("emptyNet")]
    public bool? EmptyNet { get; set; }

    [JsonPropertyName("penaltySeverity")]
    public string PenaltySeverity { get; set; } = string.Empty;

    [JsonPropertyName("penaltyMinutes")]
    public int? PenaltyMinutes { get; set; }
}
