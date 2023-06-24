using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

public class Official
{
    [JsonPropertyName("official")]
    public Person? Person { get; set; }

    [JsonPropertyName("officialType")]
    public string OfficialType { get; set; } = String.Empty;
}
