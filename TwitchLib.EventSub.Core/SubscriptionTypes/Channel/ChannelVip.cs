namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel VIP subscription type model (for VIP Add and Remove)
/// <para>Description:</para>
/// <para>VIP was added to/removed from a user on a specified channel.</para>
/// </summary>
public sealed class ChannelVip
{
    /// <summary>
    /// The ID of the user who was added/removed as a VIP.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the user who was added/removed as a VIP.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user who was added/removed as a VIP.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the broadcaster.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the broadcaster.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
}
