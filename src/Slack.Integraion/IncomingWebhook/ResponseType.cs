using System.Runtime.Serialization;



namespace Slack.Integraion.IncomingWebhook
{
    /// <summary>
    /// Represents the message response type.
    /// </summary>
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
}
