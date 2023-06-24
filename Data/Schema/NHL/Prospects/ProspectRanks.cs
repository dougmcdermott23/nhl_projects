using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Prospects;

public class ProspectRanks
{
    [JsonPropertyName("midterm")]
    public int? Midterm { get; set; }

    [JsonPropertyName("finalRank")]
    public int? FinalRank { get; set; }

    [JsonPropertyName("draftYear")]
    public int? DraftYear { get; set; }
}
