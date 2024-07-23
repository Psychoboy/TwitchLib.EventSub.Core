namespace TwitchLib.EventSub.Core.Models.Chat;

/// <summary>
/// Represents a chat message with emotes fragments
/// </summary>
public sealed class ChatMessageEmotes
{
    /// <summary>
    /// The text of the chat message.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// An array that includes the emote ID and start and end positions for where the emote appears in the text.
    /// </summary>
    public ChatMessageEmoteFragment[] Emotes { get; set; } = [];
}
