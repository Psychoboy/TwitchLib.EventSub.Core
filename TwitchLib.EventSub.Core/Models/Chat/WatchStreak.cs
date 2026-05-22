namespace TwitchLib.EventSub.Core.Models.Chat;

public class WatchStreak
{
    /// <summary>
    /// The number of consecutive broadcasts for which the user has been watching.
    /// </summary>
    public int StreakCount { get; set; }

    /// <summary>
    /// The number of channel points awarded for the Watch Streak milestone.
    /// </summary>
    public int ChannelPointsAwarded { get; set; }
}
