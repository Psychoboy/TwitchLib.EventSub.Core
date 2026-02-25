namespace TwitchLib.EventSub.Core.SubscriptionTypes.Automod;

/// <summary>
/// Automod Settings Update subscription type model
/// <para>Description:</para>
/// <para></para>
/// </summary>
public sealed class AutomodSettingsUpdate
{
    /// <summary>
    /// The ID of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the moderator who changed the channel settings.
    /// </summary>
    public string ModeratorUserId { get; set; } = string.Empty;
    /// <summary>
    /// The moderator’s login.
    /// </summary>
    public string ModeratorUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The moderator’s user name.
    /// </summary>
    public string ModeratorUserName { get; set; } = string.Empty;
    /// <summary>
    /// The Automod level for hostility involving name calling or insults.
    /// </summary>
    public int Bullying { get; set; }
    /// <summary>
    /// The default AutoMod level for the broadcaster. This field is null if the broadcaster has set one or more of the individual settings.
    /// </summary>
    public int? OverallLevel { get; set; }
    /// <summary>
    /// The Automod level for discrimination against disability.
    /// </summary>
    public int Disability { get; set; }
    /// <summary>
    /// The Automod level for racial discrimination.
    /// </summary>
    public int RaceEthnicityOrReligion { get; set; }
    /// <summary>
    /// The Automod level for discrimination against women.
    /// </summary>
    public int Misogyny { get; set; }
    /// <summary>
    /// The AutoMod level for discrimination based on sexuality, sex, or gender.
    /// </summary>
    public int SexualitySexOrGender { get; set; }
    /// <summary>
    /// The Automod level for hostility involving aggression.
    /// </summary>
    public int Aggression { get; set; }
    /// <summary>
    /// The Automod level for sexual content.
    /// </summary>
    public int SexBasedTerms { get; set; }
    /// <summary>
    /// The Automod level for profanity.
    /// </summary>
    public int Swearing { get; set; }
}
