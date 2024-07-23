using System;
using TwitchLib.EventSub.Core.Models.ChannelPoints;
using TwitchLib.EventSub.Core.Models.Chat;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Points Automatic Reward Redemption subscription type model
/// <para>!! The same for all channel points redemption subscription types !!</para>
/// <para>Description:</para>
/// <para>A viewer has redeemed an automatic channel points reward on the specified channel.</para>
/// <para>A redemption of a channel points automatic reward has been updated for the specified channel.</para>
/// </summary>
public sealed class ChannelPointsAutomaticRewardRedemption
{
    /// <summary>
    /// The ID of the Redemption.
    /// </summary>
    public string Id { get; set; } = string.Empty;
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
    /// Display name of the user that redeemed the reward.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// Login of the user that redeemed the reward.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user input provided. Empty string if not provided.
    /// </summary>
    public string UserInput { get; set; } = string.Empty;
    /// <summary>
    /// An object that contains the user message and emote information needed to recreate the message.
    /// </summary>
    public ChatMessageEmotes Message { get; set; } = new();
    /// <summary>
    /// Basic information about the reward that was redeemed, at the time it was redeemed.
    /// </summary>
    public AutomaticRedemptionReward Reward { get; set; } = new();
    /// <summary>
    /// RFC3339 timestamp of when the reward was redeemed.
    /// </summary>
    public DateTimeOffset RedeemedAt { get; set; } = DateTimeOffset.MinValue;
}
