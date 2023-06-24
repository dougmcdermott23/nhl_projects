using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Venues;

public class Venues
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("venues")]
    public List<Venue> AllVenues { get; set; } = new();
}
