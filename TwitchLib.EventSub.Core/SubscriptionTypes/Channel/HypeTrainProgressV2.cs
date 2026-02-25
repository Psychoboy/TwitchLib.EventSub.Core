using System;
using System.Diagnostics.CodeAnalysis;
using TwitchLib.EventSub.Core.Models.HypeTrain;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// HypeTrain Progress subscription type model
/// <para>Description:</para>
/// <para>A Hype Train makes progress on the specified channel.</para>
/// </summary>
public sealed class HypeTrainProgressV2
{
    /// <summary>
    /// The event ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The requested broadcaster ID.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;

    /// <summary>
    /// The requested broadcaster login.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;

    /// <summary>
    /// The requested broadcaster display name.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;

    /// <summary>
    /// Total points contributed to the Hype Train.
    /// </summary>
    public int Total { get; set; }

    /// <summary>
    /// The number of points contributed to the Hype Train at the current level.
    /// </summary>
    public int Progress { get; set; }

    /// <summary>
    /// The number of points required to reach the next level.
    /// </summary>
    public int Goal { get; set; }

    /// <summary>
    /// The contributors with the most points contributed.
    /// </summary>
    public HypeTrainContribution[] TopContributions { get; set; } = [];

    /// <summary>
    /// The current level of the Hype Train.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Non-null for a shared Hype Train. Contains the list of broadcasters in the shared Hype Train.
    /// </summary>
    public SharedTrainParticipants[]? SharedTrainParticipants { get; set; }

    /// <summary>
    /// The time when the Hype Train started.
    /// </summary>
    public DateTimeOffset StartedAt { get; set; }

    /// <summary>
    /// The time when the Hype Train expires. The expiration is extended when the Hype Train reaches a new level.
    /// </summary>
    public DateTimeOffset ExpiresAt { get; set; }

    /// <summary>
    /// The type of the Hype Train. Possible values are: treasure golden_kappa regular
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Indicates if the Hype Train is shared. When true, <see cref="SharedTrainParticipants"/> will contain the list of broadcasters the train is shared with.
    /// </summary>
#if NET8_0_OR_GREATER
    [MemberNotNullWhen(true, nameof(SharedTrainParticipants))]
#endif
    public bool IsSharedTrain { get; set; }
}
