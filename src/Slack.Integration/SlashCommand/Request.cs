using System.Runtime.Serialization;



namespace Slack.Integration.SlashCommand
{
    /// <summary>
    /// Represents a slash command request.
    /// </summary>
    /// <remarks>https://api.slack.com/slash-commands</remarks>
    [DataContract]
    public class Request
    {
        /// <summary>
        /// Gets or sets a verification token.
        /// 
        /// This is a deprecated feature that you shouldn't use any more.
        /// It was used to verify that requests were legitimately being sent by Slack to your app, but you should use the signed secrets functionality to do this instead.
        /// </summary>
        [DataMember(Name = "token")]
        public string Token { get; set; }


        /// <summary>
        /// Gets or sets a team ID.
        /// </summary>
        [DataMember(Name = "team_id")]
      //[FromForm(Name = "team_id")] なら OK だけど ASP.NET Core MVC に依存するのがイヤだから Snake Case を甘んじて受け入れる
        public string Team_Id { get; set; }


        /// <summary>
        /// Gets or sets a team domain name.
        /// </summary>
        [DataMember(Name = "team_domain")]
        public string Team_Domain { get; set; }


        /// <summary>
        /// Gets or sets a enterprise ID.
        /// </summary>
        [DataMember(Name = "enterprise_id")]
        public string Enterprise_Id { get; set; }


        /// <summary>
        /// Gets or sets a enterprise name.
        /// </summary>
        [DataMember(Name = "enterprise_name")]
        public string Enterprise_Name { get; set; }


        /// <summary>
        /// Gets or sets a channel ID.
        /// </summary>
        [DataMember(Name = "channel_id")]
        public string Channel_Id { get; set; }


        /// <summary>
        /// Gets or sets a channel name.
        /// </summary>
        [DataMember(Name = "channel_name")]
        public string Channel_Name { get; set; }


        /// <summary>
        /// Gets or sets a user ID.
        /// </summary>
        [DataMember(Name = "user_id")]
        public string User_Id { get; set; }


        /// <summary>
        /// Gets or sets a user name.
        /// </summary>
        [DataMember(Name = "user_name")]
        public string User_Name { get; set; }


        /// <summary>
        /// Gets or sets a command. (ex. /weather)
        /// </summary>
        [DataMember(Name = "command")]
        public string Command { get; set; }


        /// <summary>
        /// Gets or sets a command parameter.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }


        /// <summary>
        /// Gets or sets a response url.
        /// 
        /// You can use this url if you want to send delayed responses.
        /// </summary>
        /// <remarks>https://api.slack.com/slash-commands#responding_response_url</remarks>
        [DataMember(Name = "response_url")]
        public string Response_Url { get; set; }


        /// <summary>
        /// Gets or sets a trigger ID.
        /// 
        /// If you need to respond to the command by opening a dialog, you'll need this trigger ID to get it to work.
        /// You can use this ID with dialog.open up to 3000ms after this data payload is sent.
        /// </summary>
        /// <remarks>https://api.slack.com/slash-commands#responding_response_url</remarks>
        [DataMember(Name = "trigger_id")]
        public string Trigger_Id { get; set; }
    }
}
