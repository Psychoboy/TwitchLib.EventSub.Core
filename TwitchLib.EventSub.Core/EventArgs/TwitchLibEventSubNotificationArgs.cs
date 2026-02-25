using TwitchLib.EventSub.Core.Models;

namespace TwitchLib.EventSub.Core.EventArgs;

public abstract class TwitchLibEventSubNotificationArgs<TEvent> 
    : TwitchLibEventSubEventArgs<EventSubNotificationPayload<TEvent>>
{ }
