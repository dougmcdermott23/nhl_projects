using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams;

using Conferences;
using Divisions;
using Franchises;
using Venues;

public class Team
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("venue")]
    public Venue? Venue { get; set; }

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get; set; } = String.Empty;

    [JsonPropertyName("teamName")]
    public string TeamName { get; set; } = String.Empty;

    [JsonPropertyName("locationName")]
    public string LocationName { get; set; } = String.Empty;

    [JsonPropertyName("firstYearOfPlay")]
    public string FirstYearOfPlay { get; set; } = String.Empty;

    [JsonPropertyName("division")]
    public Division? Division { get; set; }

    [JsonPropertyName("conference")]
    public Conference? Conference { get; set; }

    [JsonPropertyName("franchise")]
    public Franchise? Franchise { get; set; }

    [JsonPropertyName("shortName")]
    public string ShortName { get; set; } = String.Empty;

    [JsonPropertyName("officialSiteUrl")]
    public string OfficialSiteUrl { get; set; } = String.Empty;

    [JsonPropertyName("franchiseId")]
    public int? FranchiseId { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}