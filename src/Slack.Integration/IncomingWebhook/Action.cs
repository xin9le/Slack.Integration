using System.Runtime.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Repesents an action field in <see cref="Attachment"/>. 
/// </summary>
public class Action
{
#pragma warning disable CS8618
    /// <summary>
    /// Gets or sets an action type.
    /// </summary>
    [DataMember(Name = "type")]
    public ActionType Type { get; set; }


    /// <summary>
    /// Gets or sets an action text.
    /// </summary>
    [DataMember(Name = "text")]
    public string Text { get; set; }


    /// <summary>
    /// Gets or sets an URL to deliver users to.
    /// </summary>
    [DataMember(Name = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Gets or sets an action style.
    /// </summary>
    [DataMember(Name = "style")]
    public ActionStyle Style { get; set; }
#pragma warning restore CS8618
}
