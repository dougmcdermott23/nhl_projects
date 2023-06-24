using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public class PlayerStats
{
    [JsonPropertyName("splits")]
    public List<PlayerSplit> PlayerSplits { get; set; } = new();
}
