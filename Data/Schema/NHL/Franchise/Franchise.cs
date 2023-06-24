using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Franchises;

public class Franchise
{
    [JsonPropertyName("franchiseId")]
    public int? FranchiseId { get; set; }

    [JsonPropertyName("firstSeasonId")]
    public int? FirstSeasonId { get; set; }

    [JsonPropertyName("mostRecentTeamId")]
    public int? MostRecentTeamId { get; set; }

    [JsonPropertyName("teamName")]
    public string TeamName { get; set; } = String.Empty;

    [JsonPropertyName("locationName")]
    public string LocationName { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("lastSeasonId")]
    public int? LastSeasonId { get; set; }
}