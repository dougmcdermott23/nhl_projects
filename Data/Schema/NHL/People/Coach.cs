using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People;

public class Coach
{
    [JsonPropertyName("person")]
    public Person? Person { get; set; }

    [JsonPropertyName("position")]
    public Position? Position { get; set; }
}
