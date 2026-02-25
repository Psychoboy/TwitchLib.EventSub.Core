namespace TwitchLib.EventSub.Core.Models.Automod;

public sealed class AutomodData
{
    /// <summary>
    /// The category of the caught message
    /// </summary>
    public string Category { get; set; } = string.Empty;
    /// <summary>
    /// The level of severity (1-4).
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// The bounds of the text that caused the message to be caught.
    /// </summary>
    public Boundary[] Boundaries { get; set; } = [];
}
