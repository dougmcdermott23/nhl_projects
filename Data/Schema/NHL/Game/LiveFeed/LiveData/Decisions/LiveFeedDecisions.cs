using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Decisions;

using People;
using Teams;

public class LiveFeedDecisions
{
    [JsonPropertyName("winner")]
    public Team? Winner { get; set; }

    [JsonPropertyName("loser")]
    public Team? Loser { get; set; }

    [JsonPropertyName("firstStar")]
    public Person? FirstStar { get; set; }

    [JsonPropertyName("secondStar")]
    public Person? SecondStar { get; set; }

    [JsonPropertyName("thirdStar")]
    public Person? ThirdStar { get; set; }
}
