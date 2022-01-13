using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents an incoming webhook payload.
/// </summary>
public class Payload
{
    /// <summary>
    /// Gets or sets a user name.
    /// </summary>
    [JsonPropertyName("username")]
    [DataMember(Name = "username")]
    public string? UserName { get; set; }


    /// <summary>
    /// Gets or sets icon url.
    /// </summary>
    [JsonPropertyName("icon_url")]
    [DataMember(Name = "icon_url")]
    public string? IconUrl { get; set; }


    /// <summary>
    /// Gets or sets emoji string for icon. (eg. :+1:)
    /// </summary>
    [JsonPropertyName("icon_emoji")]
    [DataMember(Name = "icon_emoji")]
    public string? IconEmoji { get; set; }


    /// <summary>
    /// Gets or sets main text.
    /// </summary>
    [JsonPropertyName("text")]
    [DataMember(Name = "text")]
    public string? Text { get; set; }


    /// <summary>
    /// Gets or sets whether markdown mode is enabled or not. 
    /// </summary>
    [JsonPropertyName("mrkdwn")]
    [DataMember(Name = "mrkdwn")]
    public bool Markdown { get; set; }


    /// <summary>
    /// Gets or sets the post target channel. (eg. #random)
    /// </summary>
    [JsonPropertyName("channel")]
    [DataMember(Name = "channel")]
    public string? Channel { get; set; }


    /// <summary>
    /// Gets or sets message response type.
    /// </summary>
    [JsonPropertyName("response_type")]
    [DataMember(Name = "response_type")]
    public ResponseType ResponseType { get; set; }


    /// <summary>
    /// Gets or sets whether to enable name and channel linking.
    /// </summary>
    [JsonPropertyName("link_names")]
    [DataMember(Name = "link_names")]
    public bool LinkNames { get; set; }


    /// <summary>
    /// Gets or sets parse mode.
    /// </summary>
    [JsonPropertyName("parse")]
    [DataMember(Name = "parse")]
    public ParseMode Parse { get; set; }


    /// <summary>
    /// Gets or sets the attachments.
    /// </summary>
    [JsonPropertyName("attachments")]
    [DataMember(Name = "attachments")]
    public IEnumerable<Attachment>? Attachments { get; set; }
}
