using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.BoxScore;

public class BoxScoreOnIcePlus
{
    [JsonPropertyName("playerId")]
    public int? PlayerId { get; set; }

    [JsonPropertyName("shiftDuration")]
    public int? ShiftDuration { get; set; }

    [JsonPropertyName("stamina")]
    public int? Stamina { get; set; }
}
