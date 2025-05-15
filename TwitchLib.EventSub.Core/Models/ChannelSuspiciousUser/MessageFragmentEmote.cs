namespace TwitchLib.EventSub.Core.Models.ChannelSuspiciousUser;

public sealed class FragmentEmote
{
    /// <summary>
    /// An ID that uniquely identifies this emote.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// An ID that identifies the emote set that the emote belongs to.
    /// </summary>
    public string EmoteSetId { get; set; } = string.Empty;
}
