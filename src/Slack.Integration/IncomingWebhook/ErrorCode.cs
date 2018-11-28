﻿using System.Runtime.Serialization;



namespace Slack.Integration.IncomingWebhook
{
    /// <summary>
    /// Represents the error code of response. 
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Success.
        /// <para>HTTP 200 : OK</para>
        /// </summary>
        [EnumMember(Value = "ok")]
        OK = 0,

        /// <summary>
        /// The data sent in your request cannot be understood as presented; verify your content body matches your content type and is structurally valid.
        /// <para>HTTP 400 : BadRequest</para>
        /// </summary>
        [EnumMember(Value = "invalid_payload")]
        InvalidPayload,

        /// <summary>
        /// The user used in your request does not actually exist.
        /// <para>HTTP 400 : BadRequest</para>
        /// </summary>
        [EnumMember(Value = "user_not_found")]
        UserNotFound,

        /// <summary>
        /// The team associated with your request has some kind of restriction on the webhook posting in this context.
        /// <para>HTTP 403 : Forbidden</para>
        /// </summary>
        [EnumMember(Value = "action_prohibited")]
        ActionProhibited,

        /// <summary>
        /// The channel associated with your request does not exist.
        /// <para>HTTP 404 : Not Found</para>
        /// </summary>
        [EnumMember(Value = "channel_not_found")]
        ChannelNotFound,

        /// <summary>
        /// The channel has been archived and doesn't accept further messages, even from your incoming webhook.
        /// <para>HTTP 410 : Gone</para>
        /// </summary>
        [EnumMember(Value = "channel_is_archived")]
        ChannelIsArchived,

        /// <summary>
        /// Something strange and unusual happened that was likely not your fault at all.
        /// <para>HTTP 500 : Internal Server Error</para>
        /// </summary>
        [EnumMember(Value = "rollup_error")]
        RollupError,
    }
}
