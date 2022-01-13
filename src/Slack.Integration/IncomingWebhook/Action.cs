using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Repesents an action field in <see cref="Attachment"/>. 
/// </summary>
public class Action
{
    /// <summary>
    /// Gets or sets an action type.
    /// </summary>
    [JsonPropertyName("type")]
    [DataMember(Name = "type")]
    public ActionType Type { get; set; }


    /// <summary>
    /// Gets or sets an action text.
    /// </summary>
    [JsonPropertyName("text")]
    [DataMember(Name = "text")]
    public string? Text { get; set; }


    /// <summary>
    /// Gets or sets an URL to deliver users to.
    /// </summary>
    [JsonPropertyName("url")]
    [DataMember(Name = "url")]
    public string? Url { get; set; }


    /// <summary>
    /// Gets or sets an action style.
    /// </summary>
    [JsonPropertyName("style")]
    [DataMember(Name = "style")]
    public ActionStyle Style { get; set; }
}
