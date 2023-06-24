using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.BoxScore;

public class BoxScoreTeamStats
{
    [JsonPropertyName("teamSkaterStats")]
    public BoxScoreTeamSkaterStats? TeamSkaterStats { get; set; }
}
