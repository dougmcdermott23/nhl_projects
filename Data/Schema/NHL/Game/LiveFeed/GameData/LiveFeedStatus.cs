using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.GameData;

public class LiveFeedStatus
{
    [JsonPropertyName("abstractGameState")]
    public string AbstractGameState { get; set; } = string.Empty;

    [JsonPropertyName("codedGameState")]
    public string CodedGameState { get; set; } = string.Empty;

    [JsonPropertyName("detailedState")]
    public string DetailedState { get; set; } = string.Empty;

    [JsonPropertyName("statusCode")]
    public string StatusCode { get; set; } = string.Empty;

    [JsonPropertyName("startTimeTBD")]
    public bool? StartTimeTBD { get; set; }
}
