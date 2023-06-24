using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

public class ScheduleBroadcast
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public string Type { get; set; } = String.Empty;

    [JsonPropertyName("site")]
    public string Site { get; set; } = String.Empty;

    [JsonPropertyName("language")]
    public string Language { get; set; } = String.Empty;
}
