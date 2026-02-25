namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Untimeout
{
    /// <summary>
    /// The ID of the user being untimed out.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user being untimed out.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user untimed out.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
}
