namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Unraid
{
    /// <summary>
    /// The ID of the user no longer being raided.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user no longer being raided.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the no longer user raided.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
}
