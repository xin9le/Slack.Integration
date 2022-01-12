using System.Runtime.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents action type.
/// </summary>
public enum ActionType
{
    /// <summary>
    /// 
    /// </summary>
    [EnumMember(Value = "button")]
    Button = 0,
}
