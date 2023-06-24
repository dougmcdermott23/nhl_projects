using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Standings;

public class Standings
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("records")]
    public List<Record> Records { get; set; } = new();
}
