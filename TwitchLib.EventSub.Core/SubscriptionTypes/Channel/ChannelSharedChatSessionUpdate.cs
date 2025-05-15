using TwitchLib.EventSub.Core.Models.SharedChat;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Shared Chat Session Update subscription type model
/// <para>Description:</para>
/// <para>The channel.shared_chat.update subscription type sends a notification when the active shared chat session the channel is in changes.</para>
/// </summary>
public sealed class ChannelSharedChatSessionUpdate : ChannelSharedChatSessionBase
{
    /// <summary>
    /// The list of participants in the session.
    /// </summary>
    public SharedChatParticipant[] Participants { get; set; } = [];
}