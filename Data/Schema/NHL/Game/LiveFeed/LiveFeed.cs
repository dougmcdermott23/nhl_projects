using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed;

public class LiveFeed
{
    [JsonPropertyName("gamePk")]
    public int? Id { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("metaData")]
    public LiveFeedMetaData? MetaData { get; set; }

    [JsonPropertyName("gameData")]
    public GameData.GameData? GameData { get; set; }

    [JsonPropertyName("liveData")]
    public LiveData.LiveData? LiveData { get; set; }
}
