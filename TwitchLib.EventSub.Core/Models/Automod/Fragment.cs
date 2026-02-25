namespace TwitchLib.EventSub.Core.Models.Automod;

public class Fragment
{
    /// <summary>
    ///	Message text in fragment
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// One of three options: text, emote, cheermote
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// Metadata pertaining to the emote.
    /// </summary>
    public Emote? Emote { get; set; }
    /// <summary>
    /// Metadata pertaining to the cheermote.
    /// </summary>
    public Cheermote? Cheermote { get; set; }
}
