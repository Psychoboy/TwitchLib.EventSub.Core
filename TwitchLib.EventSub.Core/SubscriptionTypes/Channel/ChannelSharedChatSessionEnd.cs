using TwitchLib.EventSub.Core.Models.SharedChat;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Shared Chat Session End subscription type model
/// <para>Description:</para>
/// <para>The channel.shared_chat.end subscription type sends a notification when a channel leaves a shared chat session or the session ends.</para>
/// </summary>
public sealed class ChannelSharedChatSessionEnd : ChannelSharedChatSessionBase
{
}