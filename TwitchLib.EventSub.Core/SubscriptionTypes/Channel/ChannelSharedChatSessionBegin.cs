using TwitchLib.EventSub.Core.Models.SharedChat;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel GuestStar Session Begin subscription type model
/// <para>Description:</para>
/// <para>The channel.shared_chat.begin subscription type sends a notification when a channel becomes active in an active shared chat session.</para>
/// </summary>
public sealed class ChannelSharedChatSessionBegin : ChannelSharedChatSessionBase
{
    /// <summary>
    /// The list of participants in the session.
    /// </summary>
    public SharedChatParticipant[] Participants { get; set; } = [];
}