﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

public sealed class ChannelSuspiciousUserMessage : ChannelSuspiciousUserBase
{
    /// <summary>
    /// A list of channel IDs where the suspicious user is also banned.
    /// </summary>
    public string[] SharedBanChannelIds { get; set; } = [];
    /// <summary>
    /// User types (if any) that apply to the suspicious user, can be “manually_added”, “ban_evader_detector”, or “shared_channel_ban”.
    /// </summary>
    public string[] Types { get; set; } = [];
    /// <summary>
    /// A ban evasion likelihood value (if any) that as been applied to the user automatically by Twitch, can be “unknown”, “possible”, or “likely”.
    /// </summary>
    public string BanEvasionEvaluation { get; set; } = string.Empty;
    /// <summary>
    /// The structured chat message.
    /// </summary>
    public SuspiciousUserMessage Message { get; set; } = new SuspiciousUserMessage();
}