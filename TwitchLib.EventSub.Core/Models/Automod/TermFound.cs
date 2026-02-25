namespace TwitchLib.EventSub.Core.Models.Automod;

public sealed class TermFound
{
    /// <summary>
    /// The id of the blocked term found.
    /// </summary>
    public string TermId { get; set; } = string.Empty;
    /// <summary>
    /// The bounds of the text that caused the message to be caught.
    /// </summary>
    public Boundary Boundary { get; set; } = new Boundary();
    /// <summary>
    /// The id of the broadcaster that owns the blocked term.
    /// </summary>
    public string OwnerBroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster that owns the blocked term
    /// </summary>
    public string OwnerBroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The username of the broadcaster that owns the blocked term.
    /// </summary>
    public string OwnerBroadcasterUserName { get; set; } = string.Empty;
}
