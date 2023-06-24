using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams;

public class Matchup<T>
{
    [JsonPropertyName("home")]
    public T? Home { get; set; }

    [JsonPropertyName("away")]
    public T? Away { get; set; }
}