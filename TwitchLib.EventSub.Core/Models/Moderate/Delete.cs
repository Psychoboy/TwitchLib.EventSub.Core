namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Delete
{
    /// <summary>
    /// The ID of the user whose message is being deleted.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the message being deleted.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The message body of the message being deleted.
    /// </summary>
    public string MessageBody { get; set; } = string.Empty;
}
