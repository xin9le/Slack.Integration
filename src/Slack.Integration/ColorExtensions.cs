using System.Drawing;

namespace Slack.Integration;



/// <summary>
/// <see cref="Color"/> の拡張機能を提供します。
/// </summary>
public static class ColorExtensions
{
    /// <summary>
    /// Converts to 16 hex string. (eg. #F0F8FF)
    /// </summary>
    /// <param name="color">value</param>
    /// <returns></returns>
    public static string ToHex(this in Color color)
        => $"#{color.R:X2}{color.G:X2}{color.B:X2}";
}
