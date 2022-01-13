using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Slack.Integration.Internals;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents the action style.
/// </summary>
[JsonConverter(typeof(EnumMemberConverter<ActionStyle>))]
public enum ActionStyle : byte
{
    /// <summary>
    /// Use UI's default text color.
    /// </summary>
    [EnumMember(Value = "default")]
    Default = 0,

    /// <summary>
    /// Turns the button green and indicates the best forward action to take.
    /// </summary>
    [EnumMember(Value = "primary")]
    Primary,

    /// <summary>
    /// Turns the button red and indicates it some kind of destructive action.
    /// </summary>
    [EnumMember(Value = "danger")]
    Danger,
}
