namespace TwitchLib.EventSub.Core.Models.Bits;

public class BitsMessage
{
    /// <summary>
    /// The chat message in plain text.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// The ordered list of chat message fragments.
    /// </summary>
    public BitsMessageFragments[] Fragments { get; set; } = [];
}
