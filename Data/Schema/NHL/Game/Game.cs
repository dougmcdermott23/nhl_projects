using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game;

public class Game
{
    [JsonPropertyName("gamePk")]
    public int? Id { get; set; }

    [JsonPropertyName("pk")]
    public int? Id2 { set { Id = value; } }

    [JsonPropertyName("season")]
    public string Season { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public string GameType { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link = String.Empty;
}
