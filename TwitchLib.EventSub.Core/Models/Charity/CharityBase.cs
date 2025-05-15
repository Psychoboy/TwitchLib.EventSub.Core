namespace TwitchLib.EventSub.Core.Models.Charity;

/// <summary>
/// Charity base class
/// </summary>
public abstract class CharityBase
{
    /// <summary>
    /// An ID that uniquely identifies the broadcaster that’s running the campaign.
    /// </summary>
    public string BroadcasterId { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    public string BroadcasterLogin { get; set; } = string.Empty;
    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    public string BroadcasterName { get; set; } = string.Empty;
    /// <summary>
    /// The charity’s name.
    /// </summary>
    public string CharityName { get; set; } = string.Empty;
    /// <summary>
    /// A description of the charity.
    /// </summary>
    public string CharityDescription { get; set; } = string.Empty;
    /// <summary>
    /// A URL to the charity’s logo.
    /// </summary>
    public string CharityLogo { get; set; } = string.Empty;
    /// <summary>
    /// A URL to the charity’s website.
    /// </summary>
    public string CharityWebsite { get; set; } = string.Empty;
}