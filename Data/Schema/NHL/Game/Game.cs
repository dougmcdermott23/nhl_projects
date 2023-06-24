using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game;

public class Game
{
    [JsonPropertyName("gamePk")]
    public int? Id { get; set; }

    [JsonPropertyName("season")]
    public string Season { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link = String.Empty;
}
