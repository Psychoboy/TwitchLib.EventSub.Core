namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Ban
{
    /// <summary>
    /// The ID of the user being banned.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user being banned.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user being banned.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// Reason given for the ban.
    /// </summary>
    public string? Reason { get; set; }
}
