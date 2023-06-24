using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Prospects;

using People;

public class Prospect : Person
{
    [JsonPropertyName("nhlPlayerId")]
    public int? NhlPlayerId { get; set; }

    [JsonPropertyName("draftStatus")]
    public string DraftStatus { get; set; } = String.Empty;

    [JsonPropertyName("prospectCategory")]
    public ProspectCategory? ProspectCategory { get; set; }

    [JsonPropertyName("amateurTeam")]
    public AmateurInfo? AmateurTeam { get; set; }

    [JsonPropertyName("amateurLeague")]
    public AmateurInfo? AmateurLeague { get; set; }

    [JsonPropertyName("ranks")]
    public ProspectRanks? Ranks { get; set; }
}
