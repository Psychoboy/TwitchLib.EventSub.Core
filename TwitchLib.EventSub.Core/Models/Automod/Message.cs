namespace TwitchLib.EventSub.Core.Models.Automod;

public sealed class Message
{
    /// <summary>
    /// The contents of the message caught by automod.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// Metadata surrounding the potential inappropriate fragments of the message
    /// </summary>
    public Fragment[] Fragments { get; set; } = [];
}
