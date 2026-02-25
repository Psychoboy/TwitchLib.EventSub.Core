namespace TwitchLib.EventSub.Core.Models;

/// <summary>
/// Defines a notification payload of an EventSub notification
/// </summary>
/// <typeparam name="TEvent">SubscriptionType</typeparam>
public class EventSubNotificationPayload<TEvent>
{
    /// <summary>
    /// Contains subscription metadata.
    /// </summary>
    public EventSubSubscription Subscription { get; set; }

    /// <summary>
    /// The event information.
    /// </summary>
    public TEvent Event { get; set; }
}
