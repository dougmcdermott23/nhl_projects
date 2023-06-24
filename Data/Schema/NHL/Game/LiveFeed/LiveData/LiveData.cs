using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData;

using BoxScore;
using Decisions;
using LineScore;
using Plays;

public class LiveData
{
    [JsonPropertyName("plays")]
    public LiveFeedPlays? Plays { get; set; }

    [JsonPropertyName("linescore")]
    public LineScore? LineScore { get; set; }

    [JsonPropertyName("boxscore")]
    public BoxScore? BoxScore { get; set; }

    [JsonPropertyName("decisions")]
    public LiveFeedDecisions? Decisions { get; set; }
}
