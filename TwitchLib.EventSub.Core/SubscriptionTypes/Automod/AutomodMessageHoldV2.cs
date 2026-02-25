using System;
using TwitchLib.EventSub.Core.Models.Automod;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Automod;

/// <summary>
/// Automod Message Hold V2 subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class AutomodMessageHoldV2
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
    /// The ID of the message that was flagged by automod.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The body of the message.
    /// </summary>
    public Message Message { get; set; } = new();
    /// <summary>
    /// The time of when automod saved the message.
    /// </summary>
    public DateTimeOffset HeldAt { get; set; }
    /// <summary>
    /// Possible values are: automod, blocked_term
    /// </summary>
    public string Reason { get; set; } = string.Empty;
    /// <summary>
    /// If the message was caught by automod, this will be populated.
    /// </summary>
    public AutomodData? Automod { get; set; }
    /// <summary>
    /// If the message was caught due to a blocked term, this will be populated
    /// </summary>
    public BlockedTerm? BlockedTerm { get; set; }
}
