namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

public sealed class AutomaticRedemptionRewardV2
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
    /// Number of channel points used.
    /// </summary>
    public int ChannelPoints { get; set; }
    /// <summary>
    /// Emote associated with the reward.
    /// </summary>
    public RewardEmote? Emote { get; set; }
}
