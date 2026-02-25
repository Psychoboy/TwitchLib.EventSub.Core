namespace TwitchLib.EventSub.Core.Models.Automod;

public sealed class BlockedTerm
{
    /// <summary>
    /// The list of blocked terms found in the message.
    /// </summary>
    public TermFound[] TermsFound { get; set; } = [];
}
