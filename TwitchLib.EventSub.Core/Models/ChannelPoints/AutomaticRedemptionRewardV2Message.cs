namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

public class AutomaticRedemptionRewardV2Message
{
    /// <summary>
    /// The chat message in plain text.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// The ordered list of chat message fragments.
    /// </summary>
    public AutomaticRedemptionRewardV2MessageFragment[] Fragments { get; set; } = [];
}
