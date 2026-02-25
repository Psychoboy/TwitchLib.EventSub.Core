using System;
using TwitchLib.EventSub.Core.Models.Automod;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Automod;

/// <summary>
/// Automod Message Update subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class AutomodMessageUpdate
{
    /// <summary>
    /// The ID of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The message sender’s user ID.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The message sender’s login name.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The message sender’s display name.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the moderator.
    /// </summary>
    public string ModeratorUserId { get; set; } = string.Empty;
    /// <summary>
    /// The moderator’s user name.
    /// </summary>
    public string ModeratorUserName { get; set; } = string.Empty;
    /// <summary>
    /// The login of the moderator.
    /// </summary>
    public string ModeratorUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the message that was flagged by automod.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The body of the message.
    /// </summary>
    public Message Message { get; set; } = new();
    /// <summary>
    /// The category of the message.
    /// </summary>
    public string Category { get; set; } = string.Empty;
    /// <summary>
    /// The level of severity. Measured between 1 to 4.
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// The message’s status. Possible values are: Approved, Denied, Expired
    /// </summary>
    public string Status { get; set; } = string.Empty;
    /// <summary>
    /// The timestamp of when automod saved the message.
    /// </summary>
    public DateTimeOffset HeldAt { get; set; }
}
