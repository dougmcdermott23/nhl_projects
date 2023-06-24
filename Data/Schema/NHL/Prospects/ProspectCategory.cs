using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Prospects;

public class ProspectCategory
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("shortName")]
    public string ShortName { get; set; } = String.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;
}
