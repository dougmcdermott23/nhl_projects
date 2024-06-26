﻿using System.Text.Json.Serialization;

namespace Data.Schema.NHL.Teams.Stats;

using NHL.Stats;

public class TeamStatsInfo
{
    [JsonPropertyName("type")]
    public StatType? Type { get; set; }

    [JsonPropertyName("splits")]
    public List<TeamSplit> Splits { get; set; } = new();
}
