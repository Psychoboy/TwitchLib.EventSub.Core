namespace TwitchLib.EventSub.Core.Models.Bits;

public class PowerUp
{
    /// <summary>
    /// Possible values are: message_effect, celebration, gigantify_an_emote
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// Emote associated with the reward.
    /// </summary>
    public PowerUpEmote? Emote { get; set; }
    /// <summary>
    /// The ID of the message effect.
    /// </summary>
    public string? MessageEffectId { get; set; }
}
