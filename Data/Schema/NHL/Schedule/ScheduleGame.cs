using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Schedule;

using Game.LineScore;
using Teams;
using Venues;

public class ScheduleGame
{
    [JsonPropertyName("gamePk")]
    public int? GamePk { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("gameType")]
    public string GameType { get; set; } = String.Empty;

    [JsonPropertyName("season")]
    public string Season { get; set; } = String.Empty;

    [JsonPropertyName("gameDate")]
    public DateTime? GameDate { get; set; }

    [JsonPropertyName("status")]
    public ScheduleGameStatus? Status { get; set; }

    [JsonPropertyName("teams")]
    public Matchup<ScheduleTeam> Teams { get; set; } = new();

    [JsonPropertyName("linescore")]
    public LineScore? Linescore { get; set; }

    [JsonPropertyName("venue")]
    public Venue? Venue { get; set; }

    [JsonPropertyName("broadcasts")]
    public List<ScheduleBroadcast> Broadcasts { get; set; } = new();
}
