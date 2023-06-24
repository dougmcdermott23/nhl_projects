using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Standings;

using Teams;

public class TeamRecord
{
    [JsonPropertyName("team")]
    public Team? Team { get; set; }

    [JsonPropertyName("leagueRecord")]
    public RecordStats? LeagueRecord { get; set; }

    [JsonPropertyName("regulationWins")]
    public int? RegulationWins { get; set; }

    [JsonPropertyName("goalsAgainst")]
    public int? GoalsAgainst { get; set; }

    [JsonPropertyName("goalsScored")]
    public int? GoalsScored { get; set; }

    [JsonPropertyName("points")]
    public int? Points { get; set; }

    [JsonPropertyName("divisionRank")]
    public string DivisionRank { get; set; } = String.Empty;

    [JsonPropertyName("divisionL10Rank")]
    public string DivisionL10Rank { get; set; } = String.Empty;

    [JsonPropertyName("divisionRoadRank")]
    public string DivisionRoadRank { get; set; } = String.Empty;

    [JsonPropertyName("divisionHomeRank")]
    public string DivisionHomeRank { get; set; } = String.Empty;

    [JsonPropertyName("conferenceRank")]
    public string ConferenceRank { get; set; } = String.Empty;

    [JsonPropertyName("conferenceL10Rank")]
    public string ConferenceL10Rank { get; set; } = String.Empty;

    [JsonPropertyName("conferenceRoadRank")]
    public string ConferenceRoadRank { get; set; } = String.Empty;

    [JsonPropertyName("conferenceHomeRank")]
    public string ConferenceHomeRank { get; set; } = String.Empty;

    [JsonPropertyName("leagueRank")]
    public string LeagueRank { get; set; } = String.Empty;

    [JsonPropertyName("leagueL10Rank")]
    public string LeagueL10Rank { get; set; } = String.Empty;

    [JsonPropertyName("leagueRoadRank")]
    public string LeagueRoadRank { get; set; } = String.Empty;

    [JsonPropertyName("leagueHomeRank")]
    public string LeagueHomeRank { get; set; } = String.Empty;

    [JsonPropertyName("wildCardRank")]
    public string WildCardRank { get; set; } = String.Empty;

    [JsonPropertyName("row")]
    public int? Row { get; set; }

    [JsonPropertyName("gamesPlayed")]
    public int? GamesPlayed { get; set; }

    [JsonPropertyName("streak")]
    public Streak? Streak { get; set; }

    [JsonPropertyName("clinchIndicator")]
    public string ClinchIndicator { get; set; } = String.Empty;

    [JsonPropertyName("pointsPercentage")]
    public double? PointsPercentage { get; set; }

    [JsonPropertyName("ppDivisionRank")]
    public string PpDivisionRank { get; set; } = String.Empty;

    [JsonPropertyName("ppConferenceRank")]
    public string PpConferenceRank { get; set; } = String.Empty;

    [JsonPropertyName("ppLeagueRank")]
    public string PpLeagueRank { get; set; } = String.Empty;

    [JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }
}
