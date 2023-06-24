using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

public class ScheduleGameStatus
{
    [JsonPropertyName("abstractGameState")]
    public string AbstractGameState { get; set; } = String.Empty;

    [JsonPropertyName("codedGameState")]
    public string CodedGameState { get; set; } = String.Empty;

    [JsonPropertyName("detailedState")]
    public string DetailedState { get; set; } = String.Empty;

    [JsonPropertyName("statusCode")]
    public string StatusCode { get; set; } = String.Empty;

    [JsonPropertyName("startTimeTBD")]
    public bool? StartTimeTBD { get; set; }
}
