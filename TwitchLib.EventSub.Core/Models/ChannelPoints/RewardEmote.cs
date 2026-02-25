namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

public sealed class RewardEmote
{
    /// <summary>
    /// The emote ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The human readable emote token.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
