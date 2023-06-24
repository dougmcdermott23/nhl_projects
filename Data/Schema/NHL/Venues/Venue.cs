using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Venues;

public class Venue
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = string.Empty;

    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    [JsonPropertyName("timeZone")]
    public TimeZone? TimeZone { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }
}