using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Drafts;

public class Draft
{
    [JsonPropertyName("draftYear")]
    public int? DraftYear { get; set; }

    [JsonPropertyName("rounds")]
    public List<Round> Rounds { get; set; } = new();
}
