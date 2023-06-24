namespace Data.Schema.NHL;

public static class EndPoints
{
    public const string BaseUrl               = @"https://statsapi.web.nhl.com/api/v1/";

    public const string Conferences           = @"conferences";                   // Get all current NHL conferences.

    public const string Conference            = @"conferences/{0}";               // Get an NHL conference.

    public const string Divisions             = @"divisions";                     // Get all current NHL divisions.

    public const string Division              = @"divisions/{0}";                 // Get an NHL division.

    public const string CurrentDraft          = @"draft";                         // Get round-by-round data for current year's NHL Entry Draft.

    public const string Draft                 = @"draft/{0}";                     // Get round-by-round data for a specific year's NHL Entry Draft.

    public const string DraftProspects        = @"draft/prospects";               // Get all NHL Entry Draft prospects.

    public const string DraftProspect         = @"draft/prospects/{0}";           // Get an NHL Entry Draft prospect.

    public const string GameBoxscore          = @"game/{0}/boxscore";             // Get the boxscore for an NHL game.

    public const string GameContent           = @"game/{0}/content";              // Get editorials, video replays and photo highlights for an NHL game.

    public const string GameLiveFeed          = @"game/{0}/feed/live";            // Get all available data for an NHL game.

    public const string GameLiveFeedDiffPatch = @"game/{0}/feed/live/diffPatch";  // Get all available data for an NHL game after a specific time.

    public const string Player                = @"people/{0}";                    // Get an NHL player.

    public const string PlayerStats           = @"people/{0}/stats";              // Get specific statistics for an NHL player.

    public const string Schedule              = @"schedule";                       // Get the NHL game schedule.

    public const string Standings             = @"standings";                      // Get NHL division standings.

    public const string StatingsType          = @"standings/{0}";                  // Get NHL standings for a specific standing type.

    public const string StandingsTypes        = @"standingsTypes";                 // Get all available NHL standing types.

    public const string StatsTypes            = @"statTypes";                      // Get all available NHL statistic types.

    public const string Teams                 = @"teams";                          // Get all NHL teams.

    public const string Team                  = @"teams/{0}";                     // Get an NHL team.

    public const string TeamRoster            = @"teams/{0}/roster";              // Get an NHL team's roster.

    public const string TeamStats             = @"teams/{0}/stats";               // Get all statistics for an NHL team.
}