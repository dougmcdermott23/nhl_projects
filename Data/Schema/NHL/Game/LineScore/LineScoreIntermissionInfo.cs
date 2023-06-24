using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LineScore;

public class LineScoreIntermissionInfo
{
    [JsonPropertyName("intermissionTimeRemaining")]
    public int? IntermissionTimeRemaining { get; set; }

    [JsonPropertyName("intermissionTimeElapsed")]
    public int? IntermissionTimeElapsed { get; set; }

    [JsonPropertyName("inIntermission")]
    public bool? InIntermission { get; set; }
}
