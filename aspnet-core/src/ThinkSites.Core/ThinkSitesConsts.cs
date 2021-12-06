using ThinkSites.Debugging;

namespace ThinkSites
{
    public class ThinkSitesConsts
    {
        public const string LocalizationSourceName = "ThinkSites";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "94a526bca0814788ad36bd4af82e6f26";
    }
}
