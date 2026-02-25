using System;

namespace TwitchLib.EventSub.Core.Models.Conduit;

public sealed class ConduitShardDisabledTransport
{
    /// <summary>
    /// websocket or webhook
    /// </summary>
    public string Method { get; set; } = string.Empty;

    /// <summary>
    /// Optional. Webhook callback URL.
    /// Null if <see cref="Method"/> is set to websocket.
    /// </summary>
    public string? Callback { get; set; }

    /// <summary>
    /// Optional. WebSocket session ID.
    /// Null if  <see cref="Method"/> is set to webhook.
    /// </summary>
    public string? SessionId { get; set; }

    /// <summary>
    /// Optional. Time that the WebSocket session connected.
    /// Null if <see cref="Method"/> is set to webhook.
    /// </summary>
    public DateTimeOffset? ConnectedAt { get; set; }

    /// <summary>
    /// Optional. Time that the WebSocket session disconnected.
    /// Null if <see cref="Method"/> is set to webhook.
    /// </summary>
    public DateTimeOffset? DisconnectedAt { get; set; }
}
