namespace TwitchLib.EventSub.Core.SubscriptionTypes.Automod;

/// <summary>
/// Automod Terms Update subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class AutomodTermsUpdate
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
    /// The ID of the moderator who changed the channel settings.
    /// </summary>
    public string ModeratorUserId { get; set; } = string.Empty;

    /// <summary>
    /// The moderator’s login.
    /// </summary>
    public string ModeratorUserLogin { get; set; } = string.Empty;

    /// <summary>
    /// The moderator’s user name.
    /// </summary>
    public string ModeratorUserName { get; set; } = string.Empty;

    /// <summary>
    /// The status change applied to the terms. Possible options are: add_permitted, remove_permitted, add_blocked, remove_blocked.
    /// </summary>
    public string Action { get; set; } = string.Empty;
    
    /// <summary>
    /// Indicates whether this term was added due to an Automod message approve/deny action.
    /// </summary>
    public bool FromAutomod { get; set; }

    /// <summary>
    /// The list of terms that had a status change.
    /// </summary>
    public string[] Terms { get; set; } = [];
}
