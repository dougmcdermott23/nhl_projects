using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LineScore;

public class LineScorePowerPlayInfo
{
    [JsonPropertyName("situationTimeRemaining")]
    public int? SituationTimeRemaining { get; set; }

    [JsonPropertyName("situationTimeElapsed")]
    public int? SituationTimeElapsed { get; set; }

    [JsonPropertyName("inSituation")]
    public bool? InSituation { get; set; }
}
