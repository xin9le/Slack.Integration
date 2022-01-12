using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Slack.Integration.Internals;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents the message response type.
/// </summary>
[JsonConverter(typeof(EnumMemberConverter<ResponseType>))]
public enum ResponseType
{
    /// <summary>
    /// Visible to all.
    /// </summary>
    [EnumMember(Value = "in_channel")]
    InChannel = 0,

    /// <summary>
    /// Visible to requester only.
    /// </summary>
    [EnumMember(Value = "ephermeral")]
    Ephermeral,
}
