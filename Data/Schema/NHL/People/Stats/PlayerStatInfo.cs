using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

using NHL.Stats;

public class PlayerStatInfo
{
    [JsonPropertyName("type")]
    public StatType? Type { get; set; }

    [JsonPropertyName("splits")]
    public List<PlayerSplit> PlayerSplits { get; set; } = new();
}
