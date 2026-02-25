using TwitchLib.EventSub.Core.Models;
using TwitchLib.EventSub.Core.SubscriptionTypes.Drop;

namespace TwitchLib.EventSub.Core.EventArgs.Drop;

public class DropEntitlementGrantArgs : TwitchLibEventSubNotificationArgs<EventSubBatchedEvent<DropEntitlementGrant>[]>
{ }
