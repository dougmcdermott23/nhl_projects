using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

public class Player
{
    [JsonPropertyName("player")]
    public Person? Person { get; set; }

    [JsonPropertyName("playerType")]
    public string PlayerType { get; set; } = String.Empty;
}
