using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Divisions;

using Conferences;

public class Division
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("nameShort")]
    public string NameShort { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get; set; } = String.Empty;

    [JsonPropertyName("conference")]
    public Conference? Conference { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}
