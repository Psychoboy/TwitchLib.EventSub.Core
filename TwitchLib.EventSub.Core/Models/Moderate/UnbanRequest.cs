namespace TwitchLib.EventSub.Core.Models.Moderate;

public class UnbanRequest
{
    ///<summary>
    ///Whether or not the unban request was approved or denied.
    ///</summary>
    public bool IsApproved { get; set; }
    ///<summary>
    ///The ID of the banned user.
    ///</summary>
    public string UserId { get; set; } = string.Empty;
    ///<summary>
    ///The login of the user.
    ///</summary>
    public string UserLogin { get; set; } = string.Empty;
    ///<summary>
    ///The user name of the user.
    ///</summary>
    public string UserName { get; set; } = string.Empty;
    ///<summary>
    ///The message included by the moderator explaining their approval or denial.
    ///</summary>
    public string ModeratorMessage { get; set; } = string.Empty;
}
