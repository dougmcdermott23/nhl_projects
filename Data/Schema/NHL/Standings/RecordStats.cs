using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Standings;

public class RecordStats
{
    [JsonPropertyName("wins")]
    public int? Wins { get; set; }

    [JsonPropertyName("losses")]
    public int? Losses { get; set; }

    [JsonPropertyName("ot")]
    public int? Ot { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
