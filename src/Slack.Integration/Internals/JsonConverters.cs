using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Slack.Integration.Internals;



/// <summary>
/// Provides <see cref="EnumMemberAttribute.Value"/> from/to JSON converter.
/// </summary>
/// <typeparam name="T"></typeparam>
internal sealed class EnumMemberConverter<T> : JsonConverter<T>
    where T : struct, Enum
{
    #region Fields
    private static readonly Dictionary<T, string> s_toNameMap;
    private static readonly Dictionary<string, T> s_toValueMap;
    #endregion


    #region Constructors
    /// <summary>
    /// 
    /// </summary>
    static EnumMemberConverter()
    {
#if NET5_0_OR_GREATER
        var pairs
            = Enum.GetValues<T>()
            .Select(static x =>
            {
                var type = typeof(T);
                var name = Enum.GetName(x)!;
                var field = type.GetField(name)!;
                var attr = field.GetCustomAttribute<EnumMemberAttribute>();
                return (name: attr?.Value, value: x);
            })
            .Where(static x => x.name is not null)
            .ToArray();
#else
        var pairs
            = (Enum.GetValues(typeof(T)) as T[])
            .Select(static x =>
            {
                var type = typeof(T);
                var name = Enum.GetName(type, x)!;
                var field = type.GetField(name)!;
                var attr = field.GetCustomAttribute<EnumMemberAttribute>();
                return (name: attr?.Value, value: x);
            })
            .Where(static x => x.name is not null)
            .ToArray();
#endif
        s_toNameMap = pairs.ToDictionary(static x => x.value, static x => x.name!);
        s_toValueMap = pairs.ToDictionary(static x => x.name!, static x => x.value);
    }
    #endregion


    #region Overrides
    /// <inheritdoc/>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            var value = reader.GetString();
            return value is null
                ? throw new KeyNotFoundException()
                : s_toValueMap[value];
        }
        catch (Exception ex)
        {
            throw new JsonException(null, ex);
        }
    }


    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        try
        {
            if (s_toNameMap.TryGetValue(value, out var name))
            {
                writer.WriteStringValue(name);
            }
            else
            {
                writer.WriteNullValue();
            }
        }
        catch (Exception ex)
        {
            throw new JsonException(null, ex);
        }
    }
    #endregion
}
