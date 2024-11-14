namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Warning Acknowledge subscription type model
/// <para>Description:</para>
/// <para>A user awknowledges a warning. Broadcasters and moderators can see the warning’s details.</para>
/// </summary>
public sealed class ChannelWarningAcknowledge
{
    /// <summary>
    /// The user ID of the broadcaster.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the broadcaster.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the user that has acknowledged their warning.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user that has acknowledged their warning.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user that has acknowledged their warning.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
}