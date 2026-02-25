namespace TwitchLib.EventSub.Core;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class Subscription
{
    public string Type { get; }
    public string Version { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Subscription"/> class.
    /// </summary>
    public Subscription(string type, string version)
    {
        Type = type;
        Version = version;
    }

    public static Subscription AutomodMessageHold { get; } = new("automod.message.hold", "1");
    public static Subscription AutomodMessageHoldV2 { get; } = new("automod.message.hold", "2");
    public static Subscription AutomodMessageUpdate { get; } = new("automod.message.update", "1");
    public static Subscription AutomodMessageUpdateV2 { get; } = new("automod.message.update", "2");
    public static Subscription AutomodSettingsUpdate { get; } = new("automod.settings.update", "1");
    public static Subscription AutomodTermsUpdate { get; } = new("automod.terms.update", "1");
    public static Subscription ChannelBitsUse { get; } = new("channel.bits.use", "1");
    public static Subscription ChannelUpdate { get; } = new("channel.update", "2");
    public static Subscription ChannelFollow { get; } = new("channel.follow", "2");
    public static Subscription ChannelAdBreakBegin { get; } = new("channel.ad_break.begin", "1");
    public static Subscription ChannelChatClear { get; } = new("channel.chat.clear", "1");
    public static Subscription ChannelChatClearUserMessages { get; } = new("channel.chat.clear_user_messages", "1");
    public static Subscription ChannelChatMessage { get; } = new("channel.chat.message", "1");
    public static Subscription ChannelChatMessageDelete { get; } = new("channel.chat.message_delete", "1");
    public static Subscription ChannelChatNotification { get; } = new("channel.chat.notification", "1");
    public static Subscription ChannelChatSettingsUpdate { get; } = new("channel.chat_settings.update", "1");
    public static Subscription ChannelChatUserMessageHold { get; } = new("channel.chat.user_message_hold", "1");
    public static Subscription ChannelChatUserMessageUpdate { get; } = new("channel.chat.user_message_update", "1");
    public static Subscription ChannelSharedChatSessionBegin { get; } = new("channel.shared_chat.begin", "1");
    public static Subscription ChannelSharedChatSessionUpdate { get; } = new("channel.shared_chat.update", "1");
    public static Subscription ChannelSharedChatSessionEnd { get; } = new("channel.shared_chat.end", "1");
    public static Subscription ChannelSubscribe { get; } = new("channel.subscribe", "1");
    public static Subscription ChannelSubscriptionEnd { get; } = new("channel.subscription.end", "1");
    public static Subscription ChannelSubscriptionGift { get; } = new("channel.subscription.gift", "1");
    public static Subscription ChannelSubscriptionMessage { get; } = new("channel.subscription.message", "1");
    public static Subscription ChannelCheer { get; } = new("channel.cheer", "1");
    public static Subscription ChannelRaid { get; } = new("channel.raid", "1");
    public static Subscription ChannelBan { get; } = new("channel.ban", "1");
    public static Subscription ChannelUnban { get; } = new("channel.unban", "1");
    public static Subscription ChannelUnbanRequestCreate { get; } = new("channel.unban_request.create", "1");
    public static Subscription ChannelUnbanRequestResolve { get; } = new("channel.unban_request.resolve", "1");
    public static Subscription ChannelModerate { get; } = new("channel.moderate", "1");
    public static Subscription ChannelModerateV2 { get; } = new("channel.moderate", "2");
    public static Subscription ChannelModeratorAdd { get; } = new("channel.moderator.add", "1");
    public static Subscription ChannelModeratorRemove { get; } = new("channel.moderator.remove", "1");
    public static Subscription ChannelGuestStarSessionBegin { get; } = new("channel.guest_star_session.begin", "beta");
    public static Subscription ChannelGuestStarSessionEnd { get; } = new("channel.guest_star_session.end", "beta");
    public static Subscription ChannelGuestStarGuestUpdate { get; } = new("channel.guest_star_guest.update", "beta");
    public static Subscription ChannelGuestStarSettingsUpdate { get; } = new("channel.guest_star_settings.update", "beta");
    public static Subscription ChannelPointsAutomaticRewardRedemptionAdd { get; } = new("channel.channel_points_automatic_reward_redemption.add", "1");
    public static Subscription ChannelPointsAutomaticRewardRedemptionAddV2 { get; } = new("channel.channel_points_automatic_reward_redemption.add", "2");
    public static Subscription ChannelPointsCustomRewardAdd { get; } = new("channel.channel_points_custom_reward.add", "1");
    public static Subscription ChannelPointsCustomRewardUpdate { get; } = new("channel.channel_points_custom_reward.update", "1");
    public static Subscription ChannelPointsCustomRewardRemove { get; } = new("channel.channel_points_custom_reward.remove", "1");
    public static Subscription ChannelPointsCustomRewardRedemptionAdd { get; } = new("channel.channel_points_custom_reward_redemption.add", "1");
    public static Subscription ChannelPointsCustomRewardRedemptionUpdate { get; } = new("channel.channel_points_custom_reward_redemption.update", "1");
    public static Subscription ChannelPollBegin { get; } = new("channel.poll.begin", "1");
    public static Subscription ChannelPollProgress { get; } = new("channel.poll.progress", "1");
    public static Subscription ChannelPollEnd { get; } = new("channel.poll.end", "1");
    public static Subscription ChannelPredictionBegin { get; } = new("channel.prediction.begin", "1");
    public static Subscription ChannelPredictionProgress { get; } = new("channel.prediction.progress", "1");
    public static Subscription ChannelPredictionLock { get; } = new("channel.prediction.lock", "1");
    public static Subscription ChannelPredictionEnd { get; } = new("channel.prediction.end", "1");
    public static Subscription ChannelSuspiciousUserMessage { get; } = new("channel.suspicious_user.message", "1");
    public static Subscription ChannelSuspiciousUserUpdate { get; } = new("channel.suspicious_user.update", "1");
    public static Subscription ChannelVipAdd { get; } = new("channel.vip.add", "1");
    public static Subscription ChannelVipRemove { get; } = new("channel.vip.remove", "1");
    public static Subscription ChannelWarningAcknowledgement { get; } = new("channel.warning.acknowledge", "1");
    public static Subscription ChannelWarningSend { get; } = new("channel.warning.send", "1");
    public static Subscription CharityDonation { get; } = new("channel.charity_campaign.donate", "1");
    public static Subscription CharityCampaignStart { get; } = new("channel.charity_campaign.start", "1");
    public static Subscription CharityCampaignProgress { get; } = new("channel.charity_campaign.progress", "1");
    public static Subscription CharityCampaignStop { get; } = new("channel.charity_campaign.stop", "1");
    public static Subscription ConduitShardDisabled { get; } = new("conduit.shard.disabled", "1");
    public static Subscription DropEntitlementGrant { get; } = new("drop.entitlement.grant", "1");
    public static Subscription ExtensionBitsTransactionCreate { get; } = new("extension.bits_transaction.create", "1");
    public static Subscription GoalBegin { get; } = new("channel.goal.begin", "1");
    public static Subscription GoalProgress { get; } = new("channel.goal.progress", "1");
    public static Subscription GoalEnd { get; } = new("channel.goal.end", "1");
    public static Subscription HypeTrainBeginV2 { get; } = new("channel.hype_train.begin", "2");
    public static Subscription HypeTrainProgressV2 { get; } = new("channel.hype_train.progress", "2");
    public static Subscription HypeTrainEndV2 { get; } = new("channel.hype_train.end", "2");
    public static Subscription ShieldModeBegin { get; } = new("channel.shield_mode.begin", "1");
    public static Subscription ShieldModeEnd { get; } = new("channel.shield_mode.end", "1");
    public static Subscription ShoutoutCreate { get; } = new("channel.shoutout.create", "1");
    public static Subscription ShoutoutReceived { get; } = new("channel.shoutout.receive", "1");
    public static Subscription StreamOnline { get; } = new("stream.online", "1");
    public static Subscription StreamOffline { get; } = new("stream.offline", "1");
    public static Subscription UserAuthorizationGrant { get; } = new("user.authorization.grant", "1");
    public static Subscription UserAuthorizationRevoke { get; } = new("user.authorization.revoke", "1");
    public static Subscription UserUpdate { get; } = new("user.update", "1");
    public static Subscription WhisperReceived { get; } = new("user.whisper.message", "1");
}
