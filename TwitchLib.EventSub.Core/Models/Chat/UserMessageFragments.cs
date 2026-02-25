namespace TwitchLib.EventSub.Core.Models.Chat;

public class UserMessageFragments
{
    /// <summary>
    /// The message text in fragment.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// The metadata pertaining to the emote.
    /// </summary>
    public UserMessageEmote? Emote { get; set; }
    /// <summary>
    /// The metadata pertaining to the cheermote.
    /// </summary>
    public UserMessageCheermote? Cheermote { get; set; }
}
