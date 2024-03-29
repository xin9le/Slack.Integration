﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Slack.Integration.SlashCommand;



/// <summary>
/// Represents a slash command request.
/// </summary>
/// <remarks>https://api.slack.com/slash-commands</remarks>
[DataContract]
public class Request
{
#pragma warning disable CS8618
    /// <summary>
    /// Gets or sets a verification token.
    /// </summary>
    /// <remarks>
    /// This is a deprecated feature that you shouldn't use any more.<br/>
    /// It was used to verify that requests were legitimately being sent by Slack to your app, but you should use the signed secrets functionality to do this instead.
    /// </remarks>
    [JsonPropertyName("token")]
    [DataMember(Name = "token")]
    public string Token { get; set; }


    /// <summary>
    /// Gets or sets a team ID.
    /// </summary>
    [JsonPropertyName("team_id")]
    [DataMember(Name = "team_id")]
    //[FromForm(Name = "team_id")] なら OK だけど ASP.NET Core MVC に依存するのがイヤだから Snake Case を甘んじて受け入れる
    public string Team_Id { get; set; }


    /// <summary>
    /// Gets or sets a team domain name.
    /// </summary>
    [JsonPropertyName("team_domain")]
    [DataMember(Name = "team_domain")]
    public string Team_Domain { get; set; }


    /// <summary>
    /// Gets or sets a enterprise ID.
    /// </summary>
    [JsonPropertyName("enterprise_id")]
    [DataMember(Name = "enterprise_id")]
    public string Enterprise_Id { get; set; }


    /// <summary>
    /// Gets or sets a enterprise name.
    /// </summary>
    [JsonPropertyName("enterprise_name")]
    [DataMember(Name = "enterprise_name")]
    public string Enterprise_Name { get; set; }


    /// <summary>
    /// Gets or sets a channel ID.
    /// </summary>
    [JsonPropertyName("channel_id")]
    [DataMember(Name = "channel_id")]
    public string Channel_Id { get; set; }


    /// <summary>
    /// Gets or sets a channel name.
    /// </summary>
    [JsonPropertyName("channel_name")]
    [DataMember(Name = "channel_name")]
    public string Channel_Name { get; set; }


    /// <summary>
    /// Gets or sets a user ID.
    /// </summary>
    [JsonPropertyName("user_id")]
    [DataMember(Name = "user_id")]
    public string User_Id { get; set; }


    /// <summary>
    /// Gets or sets a user name.
    /// </summary>
    [JsonPropertyName("user_name")]
    [DataMember(Name = "user_name")]
    public string User_Name { get; set; }


    /// <summary>
    /// Gets or sets a command. (ex. /weather)
    /// </summary>
    [JsonPropertyName("command")]
    [DataMember(Name = "command")]
    public string Command { get; set; }


    /// <summary>
    /// Gets or sets a command parameter.
    /// </summary>
    [JsonPropertyName("text")]
    [DataMember(Name = "text")]
    public string Text { get; set; }


    /// <summary>
    /// Gets or sets a response url.
    /// </summary>
    /// <remarks>
    /// You can use this url if you want to send delayed responses.<br/>
    /// <a href="https://api.slack.com/slash-commands#responding_response_url"></a>
    /// </remarks>
    [JsonPropertyName("response_url")]
    [DataMember(Name = "response_url")]
    public string Response_Url { get; set; }


    /// <summary>
    /// Gets or sets a trigger ID.
    /// </summary>
    /// <remarks>
    /// If you need to respond to the command by opening a dialog, you'll need this trigger ID to get it to work.<br/>
    /// You can use this ID with dialog.open up to 3000ms after this data payload is sent.<br/>
    /// <a href="https://api.slack.com/slash-commands#responding_response_url"></a>
    /// </remarks>
    [JsonPropertyName("trigger_id")]
    [DataMember(Name = "trigger_id")]
    public string Trigger_Id { get; set; }
#pragma warning restore CS8618
}
