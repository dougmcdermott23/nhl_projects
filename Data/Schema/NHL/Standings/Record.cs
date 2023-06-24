using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Standings;

using Conferences;
using Divisions;
using League;

public class Record
{
    [JsonPropertyName("standingsType")]
    public string StandingsType { get; set; } = String.Empty;

    [JsonPropertyName("league")]
    public League? League { get; set; }

    [JsonPropertyName("division")]
    public Division? Division { get; set; }

    [JsonPropertyName("conference")]
    public Conference? Conference { get; set; }

    [JsonPropertyName("teamRecords")]
    public List<TeamRecord> TeamRecords { get; set; } = new();

    [JsonPropertyName("divisionRecords")]
    public List<RecordStats> DivisionRecords { get; set; } = new();

    [JsonPropertyName("overallRecords")]
    public List<RecordStats> OverallRecords { get; set; } = new();

    [JsonPropertyName("conferenceRecords")]
    public List<RecordStats> ConferenceRecords { get; set; } = new();
}
