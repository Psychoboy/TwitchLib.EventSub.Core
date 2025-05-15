namespace TwitchLib.EventSub.Core.Models.SharedChat;

/// <summary>
/// A participant in the shared chat session.
/// </summary>
public class SharedChatParticipant
{
    /// <summary>
    /// The User ID of the participant's channel.
    /// </summary>
    public string BroadcasterUserId { get; protected set; } = string.Empty;
    /// <summary>
    /// The User name of the participant's channel.
    /// </summary>
    public string BroadcasterUserName { get; protected set; } = string.Empty;
    /// <summary>
    /// The User login of the participant's channel.
    /// </summary>
    public string BroadcasterUserLogin { get; protected set; } = string.Empty;
}