namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// Channel Unban Request Resolve subscription type model
    /// <para>Description:</para>
    /// <para>A moderator actions on an unban request</para>
    /// </summary>
    public sealed class ChannelUnbanRequestResolve
    {
        /// <summary>
        /// The ID of the unban request.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The broadcaster’s user ID for the channel the unban request was updated for.
        /// </summary>
        public string BroadcasterUserId { get; set; } = string.Empty;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        public string BroadcasterUserLogin { get; set; } = string.Empty;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        public string BroadcasterUserName { get; set; } = string.Empty;

        /// <summary>
        /// Optional. User ID of moderator who approved/denied the request.
        /// </summary>
        public string? ModeratorUserId { get; set; }

        /// <summary>
        /// Optional. The moderator’s login name
        /// </summary>
        public string? ModeratorUserLogin { get; set; }

        /// <summary>
        /// Optional. The moderator’s login name
        /// </summary>
        public string? ModeratorUserName { get; set; }

        /// <summary>
        /// User ID of user that requested to be unbanned.
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        public string UserLogin { get; set; } = string.Empty;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Optional. Resolution text supplied by the mod/broadcaster upon approval/denial of the request.
        /// </summary>
        public string? ResolutionText { get; set; }

        /// <summary>
        /// Dictates whether the unban request was approved or denied. Can be the following:
        /// - approved
        /// - canceled
        /// - denied
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}
