using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Slack.Integration.Internals;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents action type.
/// </summary>
[JsonConverter(typeof(EnumMemberConverter<ActionType>))]
public enum ActionType : byte
{
    /// <summary>
    /// 
    /// </summary>
    [EnumMember(Value = "button")]
    Button = 0,
}
