using System;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// Channel Unban Request Create subscription type model
    /// <para>Description:</para>
    /// <para>A viewer creates an unban request</para>
    /// </summary>
    public sealed class ChannelUnbanRequestCreate
    {
        /// <summary>
        /// The ID of the unban request.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The broadcaster’s user ID for the channel the unban request was created for.
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
        /// User ID of user that is requesting to be unbanned.
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
        /// Message sent in the unban request.
        /// </summary>
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when the unban request was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.MinValue;
    }
}
