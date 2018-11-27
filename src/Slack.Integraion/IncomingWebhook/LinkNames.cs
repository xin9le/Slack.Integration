using System.Runtime.Serialization;



namespace Slack.Integraion.IncomingWebhook
{
    /// <summary>
    /// Represents the linkify mode.
    /// </summary>
    public enum LinkNames
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "0")]
        Disable = 0,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "1")]
        Enable,
    }
}
