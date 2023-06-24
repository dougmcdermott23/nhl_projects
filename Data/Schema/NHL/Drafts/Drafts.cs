using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Drafts;

public class Drafts
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("drafts")]
    public List<Draft> AllDrafts { get; set; } = new();
}
