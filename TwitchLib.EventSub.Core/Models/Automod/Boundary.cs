namespace TwitchLib.EventSub.Core.Models.Automod;

public sealed class Boundary
{
    /// <summary>
    /// Index in the message for the start of the problem (0 indexed, inclusive).
    /// </summary>
    public int StartPos { get; set; }
    /// <summary>
    /// Index in the message for the end of the problem (0 indexed, inclusive).
    /// </summary>
    public int EndPos { get; set; }
}
