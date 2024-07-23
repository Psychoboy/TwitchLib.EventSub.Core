namespace TwitchLib.EventSub.Core.Models.Chat;

/// <summary>
/// A Fragment of a emote that holds additional information
/// </summary>
public sealed class ChatMessageEmoteFragment
{
    /// <summary>
    /// The emote ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The index of where the Emote starts in the text.
    /// </summary>
    public int Begin { get; set; }
    /// <summary>
    /// The index of where the Emote ends in the text.
    /// </summary>
    public int End { get; set; }
}
