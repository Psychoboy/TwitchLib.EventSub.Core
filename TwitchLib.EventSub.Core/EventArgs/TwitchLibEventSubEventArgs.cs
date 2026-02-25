using TwitchLib.EventSub.Core.Models;

namespace TwitchLib.EventSub.Core.EventArgs;

public abstract class TwitchLibEventSubEventArgs<TPayload> : System.EventArgs
{
    public EventSubMetadata Metadata { get; set; }
    public TPayload Payload { get; set; }
} 
