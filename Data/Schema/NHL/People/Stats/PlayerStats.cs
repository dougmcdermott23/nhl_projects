using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public class PlayerStats
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("stats")]
    public List<PlayerStatInfo> Stats { get; set; } = new();
}
