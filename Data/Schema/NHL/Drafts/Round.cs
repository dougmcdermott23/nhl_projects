using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Drafts;

public class Round
{
    [JsonPropertyName("roundNumber")]
    public int? RoundNumber { get; set; }

    [JsonPropertyName("round")]
    public string RoundName { get; set; } = String.Empty;

    [JsonPropertyName("picks")]
    public List<Pick> Picks { get; set; } = new();
}
