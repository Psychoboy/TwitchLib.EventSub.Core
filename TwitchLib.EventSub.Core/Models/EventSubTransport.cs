using System.Diagnostics;

namespace TwitchLib.EventSub.Core.Models;

/// <summary>
/// Defines an EventSub Subscription Transport
/// </summary>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class EventSubTransport
{
    /// <summary>
    /// The transport method. Supported values: webhook, websocket, conduit
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// An ID that uniquely identifies the Conduit.
    /// </summary>
    public string? ConduitId { get; set; }

    /// <summary>
    /// The callback URL where the notification is sent.
    /// </summary>
    public string? Callback { get; set; }

    /// <summary>
    /// An ID that uniquely identifies the WebSocket connection.
    /// </summary>
    public string? SessionId { get; set; }

    private string GetDebuggerDisplay()
    {
        var transportInfo = Method switch
        {
            "webhook" => Callback,
            "websocket" => SessionId,
            "conduit" => ConduitId,
            _ => "NotImplemented",
        };
        return $"{Method} - {transportInfo}";
    }
}
