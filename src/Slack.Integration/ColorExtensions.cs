using System.Drawing;

namespace Slack.Integration;



/// <summary>
/// Provides <see cref="Color"/> extension functions.
/// </summary>
public static class ColorExtensions
{
    extension(in Color @this)
    {
        /// <summary>
        /// Converts to 16 hex string. (eg. #F0F8FF)
        /// </summary>
        /// <returns></returns>
        public string ToHex()
            => $"#{@this.R:X2}{@this.G:X2}{@this.B:X2}";
    }
}
