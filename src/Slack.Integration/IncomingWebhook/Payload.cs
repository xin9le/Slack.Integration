using System.Collections.Generic;
using System.Runtime.Serialization;



namespace Slack.Integration.IncomingWebhook
{
    /// <summary>
    /// Represents an incoming webhook payload.
    /// </summary>
    public class Payload
    {
        /// <summary>
        /// Gets or sets a user name.
        /// </summary>
        [DataMember(Name = "username")]
        public string UserName { get; set; }


        /// <summary>
        /// Gets or sets icon url.
        /// </summary>
        [DataMember(Name = "icon_url")]
        public string IconUrl { get; set; }


        /// <summary>
        /// Gets or sets emoji string for icon. (eg. :+1:)
        /// </summary>
        [DataMember(Name = "icon_emoji")]
        public string IconEmoji { get; set; }


        /// <summary>
        /// Gets or sets main text.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }


        /// <summary>
        /// Gets or sets whether markdown mode is enabled or not. 
        /// </summary>
        [DataMember(Name = "mrkdwn")]
        public bool Markdown { get; set; }


        /// <summary>
        /// Gets or sets the post target channel. (eg. #random)
        /// </summary>
        [DataMember(Name = "channel")]
        public string Channel { get; set; }


        /// <summary>
        /// Gets or sets message response type.
        /// </summary>
        [DataMember(Name = "response_type")]
        public ResponseType ResponseType { get; set; }


        /// <summary>
        /// Gets or sets whether to enable name and channel linking.
        /// </summary>
        [DataMember(Name = "link_names")]
        public bool LinkNames { get; set; }


        /// <summary>
        /// Gets or sets parse mode.
        /// </summary>
        [DataMember(Name = "parse")]
        public ParseMode Parse { get; set; }


        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        [DataMember(Name = "attachments")]
        public IReadOnlyCollection<Attachment> Attachments { get; set; }
    }
}
