using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

public class Schedule
{
    [JsonPropertyName("totalItems")]
    public int? TotalItems { get; set; }

    [JsonPropertyName("totalEvents")]
    public int? TotalEvents { get; set; }

    [JsonPropertyName("totalGames")]
    public int? TotalGames { get; set; }

    [JsonPropertyName("totalMatches")]
    public int? TotalMatches { get; set; }

    [JsonPropertyName("metaData")]
    public ScheduleMetaData? MetaData { get; set; }

    [JsonPropertyName("wait")]
    public int? Wait { get; set; }

    [JsonPropertyName("dates")]
    public List<ScheduleDate> Dates { get; set; } = new();
}
