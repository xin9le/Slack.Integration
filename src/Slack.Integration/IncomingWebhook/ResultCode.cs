﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Represents the result code of response. 
/// </summary>
public enum ResultCode : byte
{
    /// <summary>
    /// Unknown
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Success.
    /// <para>HTTP 200 : OK</para>
    /// </summary>
    [EnumMember(Value = "ok")]
    OK,

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



/// <summary>
/// Provides <see cref="ResultCode"/> extension functions.
/// </summary>
internal static class ResultCodeExtensions
{
    /// <summary>
    /// Gets error message and code cache. 
    /// </summary>
    private static IReadOnlyDictionary<string, ResultCode> Cache { get; }


    /// <summary>
    /// 
    /// </summary>
    static ResultCodeExtensions()
    {
#if NET5_0_OR_GREATER
        Cache
            = Enum.GetValues<ResultCode>()
            .Select(static x =>
            {
                var name = Enum.GetName(x)!;
                var field = typeof(ResultCode).GetField(name)!;
                var attr = field.GetCustomAttribute<EnumMemberAttribute>();
                return (code: attr?.Value, value: x);
            })
            .Where(static x => x.code is not null)
            .ToDictionary(static x => x.code!, static x => x.value);
#else
        Cache
            = (Enum.GetValues(typeof(ResultCode)) as ResultCode[])
            .Select(static x =>
            {
                var type = typeof(ResultCode);
                var name = Enum.GetName(type, x)!;
                var field = type.GetField(name)!;
                var attr = field.GetCustomAttribute<EnumMemberAttribute>();
                return (code: attr?.Value, value: x);
            })
            .Where(static x => x.code is not null)
            .ToDictionary(static x => x.code!, static x => x.value);
#endif
    }


    /// <summary>
    /// Converts result message to result code.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static ResultCode ToResultCode(this string message)
        => Cache.TryGetValue(message, out var code)
        ? code
        : ResultCode.Unknown;
}
