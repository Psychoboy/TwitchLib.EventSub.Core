namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Warn
{
    /// <summary>
    /// The ID of the user being warned.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user being warned.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user being warned.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// Reason given for the warning.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// Chat rules cited for the warning.
    /// </summary>
    public string[] ChatRulesCited { get; set; } = [];
}
