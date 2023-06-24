using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.BoxScore;

using People;
using Teams;

public class BoxScore
{
    [JsonPropertyName("teams")]
    public Matchup<BoxScoreTeam>? Teams { get; set; }

    [JsonPropertyName("officials")]
    public List<Official> Officials { get; set; } = new();
}
