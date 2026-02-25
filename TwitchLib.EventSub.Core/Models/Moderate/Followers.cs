namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Followers
{
    /// <summary>
    /// The length of time, in minutes, that the followers must have followed the broadcaster to participate in the chat room.
    /// </summary>
    public int FollowDurationMinutes { get; set; }
}
