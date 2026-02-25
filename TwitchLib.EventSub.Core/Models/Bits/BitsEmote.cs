namespace TwitchLib.EventSub.Core.Models.Bits;

public class BitsEmote
{
    /// <summary>
    /// The ID that uniquely identifies this emote.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The ID that identifies the emote set that the emote belongs to.
    /// </summary>
    public string EmoteSetId { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the broadcaster who owns the emote.
    /// </summary>
    public string OwnerId { get; set; } = string.Empty;
    /// <summary>
    /// The formats that the emote is available in.
    /// The possible formats are:
    /// <para>
    /// animated - An animated GIF is available for this emote.
    /// </para>
    /// <para>
    /// static - A static PNG file is available for this emote.
    /// </para>
    /// </summary>
    /// <remarks>
    /// For example, if the emote is available only as a static PNG, the array contains only static.
    /// But if the emote is available as a static PNG and an animated GIF, the array contains static and animated.
    /// </remarks>
    public string[] Format { get; set; } = [];
}
