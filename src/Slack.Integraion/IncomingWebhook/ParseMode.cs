using System.Runtime.Serialization;



namespace Slack.Integraion.IncomingWebhook
{
    /// <summary>
    /// Represents the parse mode.
    /// </summary>
    public enum ParseMode
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "none")]
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "full")]
        Full,
    }
}
