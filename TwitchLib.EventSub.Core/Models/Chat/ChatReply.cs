namespace TwitchLib.EventSub.Core.Models.Chat;

public sealed class ChatReply
{
    /// <summary>
    /// An ID that uniquely identifies the parent message that this message is replying to.
    /// </summary>
    public string ParentMessageId { get; set; } = string.Empty;
    /// <summary>
    /// The message body of the parent message.
    /// </summary>
    public string ParentMessageBody { get; set; } = string.Empty;
    /// <summary>
    /// User ID of the sender of the parent message.
    /// </summary>
    public string ParentUserId { get; set; } = string.Empty;
    /// <summary>
    /// User name of the sender of the parent message.
    /// </summary>
    public string ParentUserName { get; set; } = string.Empty;
    /// <summary>
    /// User login of the sender of the parent message.
    /// </summary>
    public string ParentUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// An ID that identifies the parent message of the reply thread.
    /// </summary>
    public string ThreadMessageId { get; set; } = string.Empty;
    /// <summary>
    /// User ID of the sender of the thread’s parent message.
    /// </summary>
    public string ThreadUserId { get; set; } = string.Empty;
    /// <summary>
    /// User name of the sender of the thread’s parent message.
    /// </summary>
    public string ThreadUserName { get; set; } = string.Empty;
    /// <summary>
    /// User login of the sender of the thread’s parent message.
    /// </summary>
    public string ThreadUserLogin { get; set; } = string.Empty;
}
