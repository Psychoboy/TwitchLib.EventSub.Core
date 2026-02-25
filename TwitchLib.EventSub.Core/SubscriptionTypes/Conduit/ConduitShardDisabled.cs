using TwitchLib.EventSub.Core.Models.Conduit;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Conduit;

public sealed class ConduitShardDisabled
{
    /// <summary>
    /// The ID of the conduit.
    /// </summary>
    public string ConduitId { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the disabled shard.
    /// </summary>
    public string ShardId { get; set; } = string.Empty;

    /// <summary>
    /// The new status of the transport.
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// The disabled transport.
    /// </summary>
    public ConduitShardDisabledTransport Transport { get; set; } = new();
}
