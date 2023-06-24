using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

public class ScheduleDate
{
    [JsonPropertyName("date")]
    public string Date { get; set; } = String.Empty;

    [JsonPropertyName("totalItems")]
    public int? TotalItems { get; set; }

    [JsonPropertyName("totalEvents")]
    public int? TotalEvents { get; set; }

    [JsonPropertyName("totalGames")]
    public int? TotalGames { get; set; }

    [JsonPropertyName("totalMatches")]
    public int? TotalMatches { get; set; }

    [JsonPropertyName("games")]
    public List<ScheduleGame> Games { get; set; } = new();

    [JsonPropertyName("events")]
    public List<object> Events { get; set; } = new();

    [JsonPropertyName("matches")]
    public List<object> Matches { get; set; } = new();
}
