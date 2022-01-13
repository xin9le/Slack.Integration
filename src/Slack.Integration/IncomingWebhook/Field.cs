using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents a field in <see cref="Attachment"/>.
/// </summary>
public class Field
{
    /// <summary>
    /// Gets or sets a title.
    /// </summary>
    [JsonPropertyName("title")]
    [DataMember(Name = "title")]
    public string? Title { get; set; }


    /// <summary>
    /// Gets or sets a value.
    /// </summary>
    [JsonPropertyName("value")]
    [DataMember(Name = "value")]
    public string? Value { get; set; }


    /// <summary>
    /// Gets or sets whether use short field.
    /// </summary>
    [JsonPropertyName("short")]
    [DataMember(Name = "short")]
    public bool Short { get; set; }
}
