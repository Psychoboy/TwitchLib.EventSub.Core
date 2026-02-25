namespace TwitchLib.EventSub.Core.Models.Bits;

public class BitsMessageFragments
{
    /// <summary>
    /// The message text in fragment.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// The type of message fragment. Possible values are: text, cheermote, emote
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// The metadata pertaining to the emote.
    /// </summary>
    public BitsEmote? Emote { get; set; }
    /// <summary>
    /// The metadata pertaining to the cheermote.
    /// </summary>
    public BitsCheermote? Cheermote { get; set; }
}
