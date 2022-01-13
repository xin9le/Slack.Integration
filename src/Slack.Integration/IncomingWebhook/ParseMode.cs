using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Slack.Integration.Internals;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents the parse mode.
/// </summary>
[JsonConverter(typeof(EnumMemberConverter<ParseMode>))]
public enum ParseMode : byte
{
    /// <summary>
    /// 
    /// </summary>
    [EnumMember(Value = "none")]
    None = 0,

    /// <summary>
    /// 
    /// </summary>
    [EnumMember(Value = "full")]
    Full,
}
