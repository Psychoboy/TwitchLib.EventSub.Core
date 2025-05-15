namespace TwitchLib.EventSub.Core.Models.SharedChat;

public abstract class ChannelSharedChatSessionBase
{
    /// <summary>
    /// The broadcaster user ID
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster display name
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster login
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster user ID hosting shared chat
    /// </summary>
    public string HostBroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster display name hosting shared chat
    /// </summary>
    public string HostBroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster login hosting shared chat
    /// </summary>
    public string HostBroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// Unique ID representing the session.
    /// </summary>
    public string SessionId { get; set; } = string.Empty;
}