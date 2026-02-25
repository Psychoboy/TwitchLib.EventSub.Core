namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Warning Send subscription type model
/// <para>Description:</para>
/// <para>A user is sent a warning. Broadcasters and moderators can see the warning’s details.</para>
/// </summary>
public sealed class ChannelWarningSend
{
    /// <summary>
    /// The user ID of the broadcaster.
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
    /// The user ID of the moderator who sent the warning.
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
    /// The ID of the user being warned.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user being warned.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user being.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// Optional. The reason given for the warning.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// Optional. The chat rules cited for the warning.
    /// </summary>
    public string[]? ChatRulesCited { get; set; }
}
