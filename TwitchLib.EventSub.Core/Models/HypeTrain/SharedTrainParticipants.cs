namespace TwitchLib.EventSub.Core.Models.HypeTrain;

public class SharedTrainParticipants
{
    /// <summary>
    /// The ID of the broadcaster participating in the shared Hype Train.
    /// </summary>
    public int BroadcasterUserId { get; set; }

    /// <summary>
    /// The login of the broadcaster participating in the shared Hype Train.
    /// </summary>
    public int BroadcasterUserLogin { get; set; }

    /// <summary>
    /// The display name of the broadcaster participating in the shared Hype Train.
    /// </summary>
    public int BroadcasterUserName { get; set; }
}
