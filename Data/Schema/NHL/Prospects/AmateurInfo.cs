using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Prospects;

public class AmateurInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;
}
