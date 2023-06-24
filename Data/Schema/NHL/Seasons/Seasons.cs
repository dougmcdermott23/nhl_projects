using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Seasons;

public class Seasons
{
    [JsonPropertyName("copyright")]
    public string Copyright { get; set; } = String.Empty;

    [JsonPropertyName("seasons")]
    public List<Season> AllSeasons { get; set; } = new();
}
