using TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Suspicious User Message subscription type model
/// <para>Description:</para>
/// <para>A notification when a suspicious user has been updated.</para>
/// </summary>
public sealed class ChannelSuspiciousUserUpdate : ChannelSuspiciousUserBase
{
    /// <summary>
    /// The ID of the moderator that updated the treatment for a suspicious user.
    /// </summary>
    public string ModeratorUserId { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the moderator that updated the treatment for a suspicious user.
    /// </summary>
    public string ModeratorUserName { get; set; } = string.Empty;
    /// <summary>
    /// The login of the moderator that updated the treatment for a suspicious user.
    /// </summary>
    public string ModeratorUserLogin { get; set; } = string.Empty;
}
