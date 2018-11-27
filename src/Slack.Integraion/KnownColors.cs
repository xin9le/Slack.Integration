namespace Slack.Integraion
{
    /// <summary>
    /// Provides known color pattern on Slack.
    /// Like traffic signals.
    /// </summary>
    public static class KnownColors
    {
        /// <summary>
        /// Gets a good color. This value is constant.
        /// 
        /// <para>
        /// RGB : (49, 163, 82)
        /// HEX : #31A352
        /// </para>
        /// </summary>
        public const string Good = "good";


        /// <summary>
        /// Gets a warning color. This value is constant.
        /// 
        /// <para>
        /// RGB : (221, 159, 62)
        /// HEX : #DD9F3E
        /// </para>
        /// </summary>
        public const string Warning = "warning";


        /// <summary>
        /// Gets a danger color. This value is constant.
        /// 
        /// <para>
        /// RGB : (212, 24, 24)
        /// HEX : #D41818
        /// </para>
        /// </summary>
        public const string Danger = "danger";
    }
}
