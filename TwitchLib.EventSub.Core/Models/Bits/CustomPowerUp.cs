namespace TwitchLib.EventSub.Core.Models.Bits;

public class CustomPowerUp
{
    /// <summary>
    /// The title of the custom Power-up.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the custom Power-up.
    /// </summary>
    public string RewardId { get; set; } = string.Empty;
}
