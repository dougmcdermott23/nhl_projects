using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Prospects;

public class Prospects
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("prospects")]
    public List<Prospect> AllProspects { get; set; } = new();
}
