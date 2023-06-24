using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Conferences;

public class Conference
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get; set; } = String.Empty;

    [JsonPropertyName("shortName")]
    public string ShortName { get; set; } = String.Empty;

    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}
