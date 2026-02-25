using System.Diagnostics.CodeAnalysis;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Chat Settings Update subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class ChannelChatSettingsUpdate
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
    /// A Boolean value that determines whether chat messages must contain only emotes.
    /// </summary>
    public bool EmoteMode { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only, based on how long they’ve followed.
    /// </summary>
#if !NETSTANDARD
    [MemberNotNullWhen(true, nameof(FollowerModeDurationMinutes))]
#endif
    public bool FollowerMode { get; set; }
    /// <summary>
    /// The length of time, in minutes, that the followers must have followed the broadcaster to participate in the chat room.
    /// </summary>
    public int? FollowerModeDurationMinutes { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.
    /// </summary>
#if !NETSTANDARD
    [MemberNotNullWhen(true, nameof(SlowModeWaitTimeSeconds))]
#endif
    public bool SlowMode { get; set; }
    /// <summary>
    /// The amount of time, in seconds, that users need to wait between sending messages.
    /// </summary>
    public int? SlowModeWaitTimeSeconds { get; set; }
    /// <summary>
    /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel can talk in the chat room.
    /// </summary>
    public bool SubscriberMode { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.
    /// </summary>
    public bool UniqueChatMode { get; set; }
}
