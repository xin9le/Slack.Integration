using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents an attachment in payload.
/// <para>
/// https://api.slack.com/docs/message-attachments
/// </para>
/// </summary>
public class Attachment
{
#pragma warning disable CS8618
    /// <summary>
    /// Gets or sets a plain-text summary of the attachment.
    /// This text will be used in clients that don't show formatted text (eg. IRC, mobile notifications) and should not contain any markup.
    /// </summary>
    [JsonPropertyName("fallback")]
    [DataMember(Name = "fallback")]
    public string Fallback { get; set; }


    /// <summary>
    /// Gets or sets a left side border line color.
    /// </summary>
    /// <remarks>
    /// Like traffic signals, color-coding messages can quickly communicate intent and help separate them from the flow of other messages in the timeline.
    /// An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0).
    /// </remarks>
    [JsonPropertyName("color")]
    [DataMember(Name = "color")]
    public string Color { get; set; }


    /// <summary>
    /// Gets or sets an optional text that appears above the message attachment block.
    /// </summary>
    [JsonPropertyName("pretext")]
    [DataMember(Name = "pretext")]
    public string PreText { get; set; }


    /// <summary>
    /// Gets or sets a small text used to display the author's name.
    /// </summary>
    [JsonPropertyName("author_name")]
    [DataMember(Name = "author_name")]
    public string AuthorName { get; set; }


    /// <summary>
    /// Gets or sets a valid URL that will hyperlink the author_name text mentioned above.
    /// Will only work if author_name is present.
    /// </summary>
    [JsonPropertyName("author_link")]
    [DataMember(Name = "author_link")]
    public string AuthorLink { get; set; }


    /// <summary>
    /// Gets or sets a valid URL that displays a small 16 x 16 [px] image to the left of the author_name text.
    /// Will only work if author_name is present.
    /// </summary>
    [JsonPropertyName("author_icon")]
    [DataMember(Name = "author_icon")]
    public string AuthorIcon { get; set; }


    /// <summary>
    /// Gets or sets a title that is displayed as larger, bold text near the top of a message attachment.
    /// </summary>
    [JsonPropertyName("title")]
    [DataMember(Name = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Gets or sets a valid URL.
    /// The title text will be hyperlinked.
    /// </summary>
    [JsonPropertyName("title_link")]
    [DataMember(Name = "title_link")]
    public string TitleLink { get; set; }


    /// <summary>
    /// Gets or sets the main text in a message attachment, and can contain standard message markup.
    /// </summary>
    /// <remarks>
    /// The content will automatically collapse if it contains 700+ characters or 5+ linebreaks, and will display a "Show more..." link to expand the content.
    /// Links posted in the text field will not unfurl.
    /// </remarks>
    [JsonPropertyName("text")]
    [DataMember(Name = "text")]
    public string Text { get; set; }


    /// <summary>
    /// Gets or sets the fields that represents like table.
    /// </summary>
    [JsonPropertyName("fields")]
    [DataMember(Name = "fields")]
    public IReadOnlyCollection<Field> Fields { get; set; }


    /// <summary>
    /// Gets or sets the action fields.
    /// </summary>
    [JsonPropertyName("actions")]
    [DataMember(Name = "actions")]
    public IReadOnlyCollection<Action> Actions { get; set; }


    /// <summary>
    /// Gets or sets a valid URL to an image file that will be displayed inside a message attachment.
    /// </summary>
    /// <remarks>
    /// We currently support the following formats: GIF, JPEG, PNG, and BMP.
    /// Large images will be resized to a maximum width of 360px or a maximum height of 500px, while still maintaining the original aspect ratio.
    /// </remarks>
    [JsonPropertyName("image_url")]
    [DataMember(Name = "image_url")]
    public string ImageUrl { get; set; }


    /// <summary>
    /// Gets or sets a valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment.
    /// </summary>
    /// <remarks>
    /// We currently support the following formats: GIF, JPEG, PNG, and BMP.
    /// The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect ratio of the image. The filesize of the image must also be less than 500 KB.
    /// For best results, please use images that are already 75px by 75px.
    /// </remarks>
    [JsonPropertyName("thumb_url")]
    [DataMember(Name = "thumb_url")]
    public string ThumbUrl { get; set; }


    /// <summary>
    /// Gets or sets some brief text to help contextualize and identify an attachment.
    /// </summary>
    /// <remarks>
    /// Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.
    /// </remarks>
    [JsonPropertyName("footer")]
    [DataMember(Name = "footer")]
    public string Footer { get; set; }


    /// <summary>
    /// Gets or sets a valid URL that displays a small 16 x 16 [px] image to the left of the footer text.
    /// </summary>
    [JsonPropertyName("footer_icon")]
    [DataMember(Name = "footer_icon")]
    public string FooterIcon { get; set; }


    /// <summary>
    /// Gets or sets a timestamp (from Unix Epoch) that is displayed right side of footer text.
    /// </summary>
    [JsonPropertyName("ts")]
    [DataMember(Name = "ts")]
    public long Timestamp { get; set; }
#pragma warning restore CS8618
}
