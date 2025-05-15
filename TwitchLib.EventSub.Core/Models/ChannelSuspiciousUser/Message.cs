namespace TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

public sealed class SuspiciousUserMessage
{
    /// <summary>
    /// The UUID that identifies the message.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The chat message in plain text.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// Ordered list of chat message fragments.
    /// </summary>
    public MessageFragment[] Fragments { get; set; } = [];
}
