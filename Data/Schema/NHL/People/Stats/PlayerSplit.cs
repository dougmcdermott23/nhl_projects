using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

using Conferences;
using Divisions;
using Game;
using League;
using Teams;

public class PlayerSplit
{
    [JsonPropertyName("season")]
    public string Season { get; set; } = String.Empty;

    [JsonPropertyName("stat")]
    public PlayerCountingStats? Stats { get; set; }

    [JsonPropertyName("team")]
    public Team? Team { get; set; }

    [JsonPropertyName("league")]
    public League? League { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public int? SequenceNumber { get; set; }

    [JsonPropertyName("isHome")]
    public bool? IsHome { get; set; }

    [JsonPropertyName("isWin")]
    public bool? IsWin { get; set; }

    [JsonPropertyName("isOT")]
    public bool? IsOT { get; set; }

    [JsonPropertyName("date")]
    public string Date { get; set; } = String.Empty;

    [JsonPropertyName("month")]
    public int? Month { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    [JsonPropertyName("opponent")]
    public Team? Opponent { get; set; }

    [JsonPropertyName("opponentDivision")]
    public Division? OpponentDivision { get; set; }

    [JsonPropertyName("opponentConference")]
    public Conference? OpponentConference { get; set; }

    [JsonPropertyName("game")]
    public Game? Game { get; set; }
}
