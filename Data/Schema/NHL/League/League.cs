using System.Text.Json.Serialization;

namespace Data.Schema.NHL.League;

public class League
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public int? Id { get; set; }
}
