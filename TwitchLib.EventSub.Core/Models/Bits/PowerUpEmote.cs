namespace TwitchLib.EventSub.Core.Models.Bits;

public class PowerUpEmote
{
    /// <summary>
    /// The ID that uniquely identifies this emote.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The human readable emote token.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
