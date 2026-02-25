using TwitchLib.EventSub.Core.Models.Bits;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Bits Use subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class ChannelBitsUse
{
    /// <summary>
    /// The User ID of the channel where the Bits were redeemed.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the channel where the Bits were used.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the channel where the Bits were used.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The User ID of the redeeming user.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login name of the redeeming user.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the redeeming user.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The number of Bits used.
    /// </summary>
    public int Bits { get; set; }
    /// <summary>
    /// Possible values are: cheer, power_up
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// An object that contains the user message and emote information needed to recreate the message.
    /// </summary>
    public BitsMessage? Message { get; set; }
    /// <summary>
    /// Data about Power-up.
    /// </summary>
    public PowerUp? PowerUp { get; set; }
}
