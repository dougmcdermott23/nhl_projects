using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

using Teams;

public class Person
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("fullName")]
    public string FullName { get; set; } = String.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = String.Empty;

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = String.Empty;

    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = String.Empty;

    [JsonPropertyName("primaryNumber")]
    public string PrimaryNumber { get; set; } = String.Empty;

    [JsonPropertyName("birthDate")]
    public string BirthDate { get; set; } = String.Empty;

    [JsonPropertyName("currentAge")]
    public int? CurrentAge { get; set; }

    [JsonPropertyName("birthCity")]
    public string BirthCity { get; set; } = String.Empty;

    [JsonPropertyName("birthStateProvince")]
    public string BirthStateProvince { get; set; } = String.Empty;

    [JsonPropertyName("birthCountry")]
    public string BirthCountry { get; set; } = String.Empty;

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; } = String.Empty;

    [JsonPropertyName("height")]
    public string Height { get; set; } = String.Empty;

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("alternateCaptain")]
    public bool? AlternateCaptain { get; set; }

    [JsonPropertyName("captain")]
    public bool? Captain { get; set; }

    [JsonPropertyName("rookie")]
    public bool? Rookie { get; set; }

    [JsonPropertyName("shootsCatches")]
    public string ShootsCatches { get; set; } = String.Empty;

    [JsonPropertyName("rosterStatus")]
    public string RosterStatus { get; set; } = String.Empty;

    [JsonPropertyName("currentTeam")]
    public Team? CurrentTeam { get; set; }

    [JsonPropertyName("primaryPosition")]
    public Position? PrimaryPosition { get; set; }
}