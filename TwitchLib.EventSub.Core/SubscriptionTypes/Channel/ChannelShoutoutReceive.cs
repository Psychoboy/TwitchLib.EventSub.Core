using TwitchLib.EventSub.Core.Models.Shoutouts;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Shoutout Receive subscription type model
/// <para>Description:</para>
/// <para>Defines the Shoutout data that you receive when the channel.shoutout.receive event occurs.</para>
/// </summary>
public sealed class ChannelShoutoutReceive : ShoutoutBase
{
    /// <summary>
    /// An ID that identifies the broadcaster that sent the Shoutout.
    /// </summary>
    public string FromBroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    public string FromBroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    public string FromBroadcasterUserLogin { get; set; } = string.Empty;
}