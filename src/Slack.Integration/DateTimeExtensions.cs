using System;

namespace Slack.Integration;



/// <summary>
/// Provides <see cref="DateTime"/> extension functions.
/// </summary>
public static class DateTimeExtensions
{
    #region Constants
    /// <summary>
    /// Gets the Unix Epoch. This valus is constant.
    /// </summary>
    private static readonly DateTime s_unixEpoch = new(1970, 1, 1, 0, 0, 0);
    #endregion


    #region Methods
    /// <summary>
    /// Gets elapsed seconds from Unix Epoch (1970/01/01 00:00:00).
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long ToUnixTimeSeconds(this in DateTime value)
    {
        var utc = value.ToUniversalTime();
        var elapsed = utc - s_unixEpoch;
        return (long)elapsed.TotalSeconds;
    }
    #endregion
}
