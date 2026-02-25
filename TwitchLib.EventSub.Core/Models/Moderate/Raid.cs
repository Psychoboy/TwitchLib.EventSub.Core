namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Raid
{
    /// <summary>
    /// The user ID of the broadcaster raiding this channel.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the broadcaster raiding this channel.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The login name of the broadcaster raiding this channel.
    /// </summary> 
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The number of viewers raiding this channel from the broadcaster’s channel.
    /// </summary>
    public int ViewerCount { get; set; }
}
