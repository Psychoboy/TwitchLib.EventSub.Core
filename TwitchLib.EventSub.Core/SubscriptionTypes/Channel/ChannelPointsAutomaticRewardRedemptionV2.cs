using System;
using TwitchLib.EventSub.Core.Models.ChannelPoints;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Points Automatic Reward Redemption V2 subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class ChannelPointsAutomaticRewardRedemptionV2
{
    /// <summary>
    /// The ID of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the redeeming user.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the redeeming user.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the redeeming user.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the Redemption.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// An object that contains the reward information.
    /// </summary>
    public AutomaticRedemptionRewardV2 Reward { get; set; } = new();
    /// <summary>
    /// An object that contains the user message and emote information needed to recreate the message.
    /// </summary>
    public AutomaticRedemptionRewardV2Message? Message { get; set; }
    /// <summary>
    /// The UTC date and time of when the reward was redeemed.
    /// </summary>
    public DateTimeOffset RedeemedAt { get; set; }
}
