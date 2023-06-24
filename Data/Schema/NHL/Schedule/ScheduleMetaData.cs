using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

public class ScheduleMetaData
{
    [JsonPropertyName("timeStamp")]
    public string TimeStamp { get; set; } = String.Empty;
}
