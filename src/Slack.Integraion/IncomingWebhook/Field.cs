using System.Runtime.Serialization;



namespace Slack.Integraion.IncomingWebhook
{
    /// <summary>
    /// Represents a field in <see cref="Attachment"/>.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or sets a title.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }


        /// <summary>
        /// Gets or sets a value.
        /// </summary>
        [DataMember(Name = "value")]
        public string Value { get; set; }


        /// <summary>
        /// Gets or sets whether use short field.
        /// </summary>
        [DataMember(Name = "short")]
        public bool Short { get; set; }
    }
}
