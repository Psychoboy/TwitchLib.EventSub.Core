namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

/// <summary>
/// Basic information about the reward that was automatically redeemed, at the time it was redeemed.
/// </summary>
public sealed class AutomaticRedemptionReward
{
    /// <summary>
    /// The type of reward. One of:
    /// ssingle_message_bypass_sub_mode
    /// send_highlighted_message
    /// random_sub_emote_unlock
    /// chosen_sub_emote_unlock
    /// chosen_modified_sub_emote_unlock
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// The reward cost.
    /// </summary>
    public int Cost { get; set; }
    /// <summary>
    /// Optional. Emote that was unlocked.
    /// </summary>
    public UnlockedEmote? UnlockedEmote { get; set; }
}
