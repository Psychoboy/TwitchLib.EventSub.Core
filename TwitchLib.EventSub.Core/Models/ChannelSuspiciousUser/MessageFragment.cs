namespace TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

public sealed class MessageFragment
{
    /// <summary>
    /// The type of message fragment. Possible values: -text -cheermote -emote
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// Message text in fragment.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// Optional. Metadata pertaining to the cheermote.
    /// </summary>
    public FragmentCheermote? Cheermote { get; set; }
    /// <summary>
    /// Optional. Metadata pertaining to the emote.
    /// </summary>
    public FragmentEmote? Emote { get; set; }
}
