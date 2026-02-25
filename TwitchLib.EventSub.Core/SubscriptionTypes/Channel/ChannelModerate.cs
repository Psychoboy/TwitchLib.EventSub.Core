using TwitchLib.EventSub.Core.Models.Moderate;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Moderate subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class ChannelModerate
{
    /// <summary>
    /// The ID of the broadcaster.
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
    /// The channel in which the action originally occurred. Is the same as the <see cref="BroadcasterUserId" /> if not in shared chat.
    /// </summary>
    public string SourceBroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The channel in which the action originally occurred. Is the same as the <see cref="BroadcasterUserLogin" /> if not in shared chat.
    /// </summary>
    public string SourceBroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The channel in which the action originally occurred.
    /// </summary>
    /// <remarks>
    /// Is null when the moderator action happens in the same channel as the broadcaster.
    /// <para/>
    /// Is not null when in a shared chat session, and the action happens in the channel of a participant other than the broadcaster.
    /// </remarks>
    public string? SourceBroadcasterUserName { get; set; }
    /// <summary>
    /// The ID of the moderator who performed the action.
    /// </summary>
    public string ModeratorUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the moderator.
    /// </summary>
    public string ModeratorUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the moderator.
    /// </summary>
    public string ModeratorUserName { get; set; } = string.Empty;
    /// <summary>
    /// The type of action: Possible values are:
    /// ban, timeout, unban untimeout, clear, emoteonly, emoteonlyoff, followers, followersoff, uniquechat, uniquechatoff, slow, slowoff, subscribers, subscribersoff, unraid, delete, unvip, vip, raid, add_blocked_term, add_permitted_term, remove_blocked_term, remove_permitted_term, mod, unmod, approve_unban_request, deny_unban_request, shared_chat_ban, shared_chat_timeout, shared_chat_untimeout, shared_chat_unban, shared_chat_delete
    /// </summary>
    public string Action { get; set; } = string.Empty;
    /// <summary>
    /// Metadata associated with the followers command.
    /// </summary>
    public Followers? Followers { get; set; }
    /// <summary>
    /// Metadata associated with the slow command.
    /// </summary>
    public Slow? Slow { get; set; }
    /// <summary>
    /// Metadata associated with the vip command.
    /// </summary>
    public Vip? Vip { get; set; }
    /// <summary>
    /// Metadata associated with the unvip command.
    /// </summary>
    public Vip? Unvip { get; set; }
    /// <summary>
    /// Metadata associated with the mod command.
    /// </summary>
    public Moderator? Mod { get; set; }
    /// <summary>
    /// Metadata associated with the unmod command.
    /// </summary>
    public Moderator? Unmod { get; set; }
    /// <summary>
    /// Metadata associated with the ban command.
    /// </summary>
    public Ban? Ban { get; set; }
    /// <summary>
    /// Metadata associated with the unban command.
    /// </summary>
    public Unban? Unban { get; set; }
    /// <summary>
    /// Metadata associated with the timeout command.
    /// </summary>
    public Timeout? Timeout { get; set; }
    /// <summary>
    /// Metadata associated with the untimeout command.
    /// </summary>
    public Untimeout? Untimeout { get; set; }
    /// <summary>
    /// Metadata associated with the raid command.
    /// </summary>
    public Raid? Raid { get; set; }
    /// <summary>
    /// Metadata associated with the unraid command.
    /// </summary>
    public Unraid? Unraid { get; set; }
    /// <summary>
    /// Metadata associated with the delete command.
    /// </summary>
    public Delete? Delete { get; set; }
    /// <summary>
    /// Metadata associated with the automod terms changes.
    /// </summary>
    public AutomodTerms? AutomodTerms { get; set; }
    /// <summary>
    /// Metadata associated with an unban request.
    /// </summary>
    public UnbanRequest? UnbanRequest { get; set; }
    /// <summary>
    /// Information about the shared_chat_ban event.
    /// </summary>
    /// <remarks>
    /// Is <see langword="null"/> if <see cref="Action"/> is not shared_chat_ban.
    /// <br/>
    /// This field has the same information as the <see cref="Ban"/> field but for a action that happened for a channel in a shared chat session other than the broadcaster in the subscription condition.
    /// </remarks>
    public Ban? SharedChatBan { get; set; }
    /// <summary>
    /// Information about the shared_chat_unban event.
    /// </summary>
    /// <remarks>
    /// Is <see langword="null"/> if <see cref="Action"/> is not shared_chat_unban.
    /// <br/>
    /// This field has the same information as the <see cref="Unban"/> field but for a action that happened for a channel in a shared chat session other than the broadcaster in the subscription condition.
    /// </remarks>
    public Unban? SharedChatUnban { get; set; }
    /// <summary>
    /// Information about the shared_chat_timeout event.
    /// </summary>
    /// <remarks>
    /// Is <see langword="null"/> if <see cref="Action"/> is not shared_chat_timeout.
    /// <br/>
    /// This field has the same information as the <see cref="Timeout"/> field but for a action that happened for a channel in a shared chat session other than the broadcaster in the subscription condition.
    /// </remarks>
    public Timeout? SharedChatTimeout { get; set; }
    /// <summary>
    /// Information about the shared_chat_untimeout event.
    /// </summary>
    /// <remarks>
    /// Is <see langword="null"/> if <see cref="Action"/> is not shared_chat_untimeout.
    /// <br/>
    /// This field has the same information as the <see cref="Untimeout"/> field but for a action that happened for a channel in a shared chat session other than the broadcaster in the subscription condition.
    /// </remarks>
    public Untimeout? SharedChatUntimeout { get; set; }
    /// <summary>
    /// Information about the shared_chat_delete event.
    /// </summary>
    /// <remarks>
    /// Is <see langword="null"/> if <see cref="Action"/> is not shared_chat_delete.
    /// <br/>
    /// This field has the same information as the <see cref="Delete"/> field but for a action that happened for a channel in a shared chat session other than the broadcaster in the subscription condition.
    /// </remarks>
    public Delete? SharedChatDelete { get; set; }
}
