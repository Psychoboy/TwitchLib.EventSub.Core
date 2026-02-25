using System;

namespace TwitchLib.EventSub.Core.Models.Moderate;

public class Timeout
{
    /// <summary>
    /// The ID of the user being timed out.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the user being timed out.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the user being timed out.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The reason given for the timeout.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The time at which the timeout ends.
    /// </summary>
    public DateTimeOffset ExpiresAt { get; set; } = DateTimeOffset.MinValue;
}
