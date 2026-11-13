using System;

namespace Slack.Integration;



/// <summary>
/// Provides <see cref="DateTime"/> extension functions.
/// </summary>
public static class DateTimeExtensions
{
    #region Constants
    private static readonly DateTime s_unixEpoch = new(1970, 1, 1, 0, 0, 0);
    #endregion


    extension(in DateTime @this)
    {
        /// <summary>
        /// Gets elapsed seconds from Unix Epoch (1970/01/01 00:00:00).
        /// </summary>
        /// <returns></returns>
        public long ToUnixTimeSeconds()
        {
            var utc = @this.ToUniversalTime();
            var elapsed = utc - s_unixEpoch;
            return (long)elapsed.TotalSeconds;
        }
    }
}
