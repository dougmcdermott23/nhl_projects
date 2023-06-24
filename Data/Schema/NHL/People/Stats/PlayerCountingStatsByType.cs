using System.Text.Json.Serialization;

namespace Data.Schema.NHL.People.Stats;

public class PlayerCountingStatsByType
{
    [JsonPropertyName("skaterStats")]
    public PlayerCountingStats? PlayerStats { get; set; }

    [JsonPropertyName("goalieStats")]
    public PlayerCountingStats? GoalieStats { get; set; }
}
