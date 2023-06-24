using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Drafts;

using Prospects;
using Teams;

public class Pick
{
    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; } = String.Empty;

    [JsonPropertyName("pickOverall")]
    public int? PickOverall { get; set; }

    [JsonPropertyName("pickInRound")]
    public int? PickInRound { get; set; }

    [JsonPropertyName("team")]
    public Team? Team { get; set; }

    [JsonPropertyName("prospect")]
    public Prospect? Prospect { get; set; }
}
