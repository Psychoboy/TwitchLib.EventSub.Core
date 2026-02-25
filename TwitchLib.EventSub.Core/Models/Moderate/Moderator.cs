namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Moderator
{
    /// <summary>
    /// The ID of the user gaining/losing mod status.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user gaining/losing mod status.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user gaining/losing mod status.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
}
