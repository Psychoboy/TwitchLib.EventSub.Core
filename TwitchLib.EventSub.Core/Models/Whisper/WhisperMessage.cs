namespace TwitchLib.EventSub.Core.Models.Whisper;

/// <summary>
/// Represents a whisper message
/// </summary>
public sealed class WhisperMessage
{
    /// <summary>
    /// The body of the whisper message.
    /// </summary>
    public string Text { get; set; } = string.Empty;
}
