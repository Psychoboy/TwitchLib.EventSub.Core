using TwitchLib.EventSub.Core.Models.Whisper;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.User;

/// <summary>
/// Channel Whisper Received subscription type model
/// <para>Description:</para>
/// <para>The user.whisper.message subscription type sends a notification when a user receives a whisper.</para>
/// </summary>
public sealed class UserWhisperMessage
{
    /// <summary>
    /// The ID of the user sending the message.
    /// </summary>
    public string FromUserId { get; set; } = string.Empty;
    /// <summary>
    /// The name of the user sending the message.
    /// </summary>
    public string FromUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user sending the message.
    /// </summary>
    public string FromUserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the user receiving the message.
    /// </summary>
    public string ToUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user receiving the message.
    /// </summary>
    public string ToUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The name of the user receiving the message.
    /// </summary>
    public string ToUserName { get; set; } = string.Empty;
    /// <summary>
    /// The whisper ID.
    /// </summary>
    public string WhisperId { get; set; } = string.Empty;
    /// <summary>
    /// The structured whisper message
    /// </summary>
    public WhisperMessage Whisper { get; set; } = new();
}
