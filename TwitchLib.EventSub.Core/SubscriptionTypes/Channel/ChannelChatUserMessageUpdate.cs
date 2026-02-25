using TwitchLib.EventSub.Core.Models.Chat;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Chat User Message Update subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class ChannelChatUserMessageUpdate
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
    /// The User ID of the message sender.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The message sender’s login.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The message sender’s display name.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The message’s status. Possible values are: approved, denied, invalid
    /// </summary>
    public string Status { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the message that was flagged by automod.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The body of the message.
    /// </summary>
    public ChatUserMessage Message { get; set; } = new();
}
