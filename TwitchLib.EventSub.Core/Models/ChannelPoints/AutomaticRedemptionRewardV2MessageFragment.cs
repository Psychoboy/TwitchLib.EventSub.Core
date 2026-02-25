namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

public class AutomaticRedemptionRewardV2MessageFragment
{
    /// <summary>
    /// The message text in fragment.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// The type of message fragment. Possible values are: text, emote
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// The metadata pertaining to the emote.
    /// </summary>
    public AutomaticRedemptionRewardV2MessageFragmentEmote? Emote { get; set; }
}
