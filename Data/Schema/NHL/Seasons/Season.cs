using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Seasons;

public class Season
{
    [JsonPropertyName("seasonId")]
    public string SeasonId { get; set; } = String.Empty;

    [JsonPropertyName("regularSeasonStartDate")]
    public string RegularSeasonStartDate { get; set; } = String.Empty;

    [JsonPropertyName("regularSeasonEndDate")]
    public string RegularSeasonEndDate { get; set; } = String.Empty;

    [JsonPropertyName("seasonEndDate")]
    public string SeasonEndDate { get; set; } = String.Empty;

    [JsonPropertyName("numberOfGames")]
    public int? NumberOfGames { get; set; }

    [JsonPropertyName("tiesInUse")]
    public bool? TiesInUse { get; set; }

    [JsonPropertyName("olympicsParticipation")]
    public bool? OlympicsParticipation { get; set; }

    [JsonPropertyName("conferencesInUse")]
    public bool? ConferencesInUse { get; set; }

    [JsonPropertyName("divisionsInUse")]
    public bool? DivisionsInUse { get; set; }

    [JsonPropertyName("wildCardInUse")]
    public bool? WildCardInUse { get; set; }
}
