namespace TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

/// <summary>
/// Channel suspicious user base class.
/// </summary>
public abstract class ChannelSuspiciousUserBase
{
    /// <summary>
    /// The ID of the channel where the treatment for a suspicious user was updated.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the channel where the treatment for a suspicious user was updated.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The login of the channel where the treatment for a suspicious user was updated.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user ID of the user that sent the message.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user that sent the message.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// 	The user login of the user that sent the message.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The status set for the suspicious user. Can be the following: “no_treatment”, “active_monitoring”, or “restricted”
    /// </summary>
    public string LowTrustStatus { get; set; } = string.Empty;
}
