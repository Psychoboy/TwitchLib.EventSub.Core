namespace TwitchLib.EventSub.Core.Models.Moderate;

public class AutomodTerms
{
    ///<summary>
    ///Either “add” or “remove”.
    ///</summary>
    public string Action { get; set; } = string.Empty;
    ///<summary>
    ///The type of AutoModTerm list, either “blocked” or “permitted”.
    ///</summary>
    public string List { get; set; } = string.Empty;
    ///<summary>
    ///Terms being added or removed.
    ///</summary>
    public string[] Terms { get; set; } = [];
    ///<summary>
    ///Whether the terms were added due to an Automod message approve/deny action.
    ///</summary>
    public bool FromAutomod { get; set; }
}
