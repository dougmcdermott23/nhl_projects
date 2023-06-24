using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

public class Position
{
    [JsonPropertyName("code")]
    public string Code { get; set; } = String.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public string Type { get; set; } = String.Empty;

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get; set; } = String.Empty;
}
