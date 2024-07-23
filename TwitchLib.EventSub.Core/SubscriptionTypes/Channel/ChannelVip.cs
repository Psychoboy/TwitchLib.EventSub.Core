﻿namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel VIP subscription type model (for VIP Add and Remove)
/// <para>Description:</para>
/// <para>VIP was added to/removed from a user on a specified channel.</para>
/// </summary>
public sealed class ChannelVip
{
    /// <summary>
    /// The user ID of the new/removed moderator.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the new/removed moderator.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The user login of the new/removed moderator.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The requested broadcaster ID.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The requested broadcaster display name.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The requested broadcaster login.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
}