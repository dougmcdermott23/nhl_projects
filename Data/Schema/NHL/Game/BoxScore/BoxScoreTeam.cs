using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.BoxScore;

using People;
using Teams;

public class BoxScoreTeam
{
    [JsonPropertyName("team")]
    public Team? Team { get; set; }

    [JsonPropertyName("teamStats")]
    public BoxScoreTeamStats? TeamStats { get; set; }

    [JsonPropertyName("players")]
    public Dictionary<string, Player> Players { get; set; } = new();

    [JsonPropertyName("goalies")]
    public List<int?> Goalies { get; set; } = new();

    [JsonPropertyName("skaters")]
    public List<int?> Skaters { get; set; } = new();

    [JsonPropertyName("onIce")]
    public List<int?> OnIce { get; set; } = new();

    [JsonPropertyName("onIcePlus")]
    public List<BoxScoreOnIcePlus> OnIcePlus { get; set; } = new();

    [JsonPropertyName("scratches")]
    public List<int?> Scratches { get; set; } = new();

    [JsonPropertyName("penaltyBox")]
    public List<int?> PenaltyBox { get; set; } = new();

    [JsonPropertyName("coaches")]
    public List<Coach> Coaches { get; set; } = new();
}
