using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Venues;

public class TimeZone
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    [JsonPropertyName("tz")]
    public string Tz { get; set; } = string.Empty;
}
