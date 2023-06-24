using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays;

public class PlaysByPeriod
{
    [JsonPropertyName("startIndex")]
    public int? StartIndex { get; set; }

    [JsonPropertyName("plays")]
    public List<int?> Plays { get; set; } = new();

    [JsonPropertyName("endIndex")]
    public int? EndIndex { get; set; }
}
