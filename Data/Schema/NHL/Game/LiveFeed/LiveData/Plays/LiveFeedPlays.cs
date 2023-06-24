using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Game.LiveFeed.LiveData.Plays;

public class LiveFeedPlays
{
    [JsonPropertyName("allPlays")]
    public List<Play.Play> AllPlays { get; set; } = new();

    [JsonPropertyName("scoringPlays")]
    public List<int?> ScoringPlays { get; set; } = new();

    [JsonPropertyName("penaltyPlays")]
    public List<int?> PenaltyPlays { get; set; } = new();

    [JsonPropertyName("playsByPeriod")]
    public List<PlaysByPeriod> PlaysByPeriod { get; set; } = new();

    [JsonPropertyName("currentPlay")]
    public Play.Play? CurrentPlay { get; set; }
}
