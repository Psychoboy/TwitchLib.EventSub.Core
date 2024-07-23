namespace TwitchLib.EventSub.Core.Models.ChannelPoints;

/// <summary>
/// Represents a unlocked emote
/// </summary>
public sealed class UnlockedEmote 
{
    /// <summary>
    /// The emote ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The human readable emote token.
    /// </summary>
    public string Name {  get; set; } = string.Empty;
}
