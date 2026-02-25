namespace TwitchLib.EventSub.Core.Models.Chat;

public class ChatUserMessage
{
    /// <summary>
    /// The contents of the message caught by automod.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// The ordered list of chat message fragments.
    /// </summary>
    public UserMessageFragments[] Fragments { get; set; } = [];
}
