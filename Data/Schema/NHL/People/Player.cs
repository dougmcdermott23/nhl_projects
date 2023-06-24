using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

using Stats;

public class Player
{
    [JsonPropertyName("person")]
    public Person? Person { get; set; }

    [JsonPropertyName("player")]
    public Person? Person2 { set { Person = value; } }

    [JsonPropertyName("playerType")]
    public string PlayerType { get; set; } = String.Empty;

    [JsonPropertyName("jerseyNumber")]
    public string JerseyNumber { get; set; } = String.Empty;

    [JsonPropertyName("position")]
    public Position? Position { get; set; }

    [JsonPropertyName("stats")]
    public PlayerCountingStatsByType? Stats { get; set; }
}
