namespace TwitchLib.EventSub.Core.Models.Chat;

public class UserMessageEmote
{
    /// <summary>
    /// The ID that uniquely identifies this emote.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The ID that identifies the emote set that the emote belongs to.
    /// </summary>
    public string EmoteSetId { get; set; } = string.Empty;
}