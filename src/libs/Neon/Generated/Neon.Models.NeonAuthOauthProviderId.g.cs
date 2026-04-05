
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthOauthProviderId
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthOauthProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthOauthProviderId value)
        {
            return value switch
            {
                NeonAuthOauthProviderId.Github => "github",
                NeonAuthOauthProviderId.Google => "google",
                NeonAuthOauthProviderId.Microsoft => "microsoft",
                NeonAuthOauthProviderId.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthOauthProviderId? ToEnum(string value)
        {
            return value switch
            {
                "github" => NeonAuthOauthProviderId.Github,
                "google" => NeonAuthOauthProviderId.Google,
                "microsoft" => NeonAuthOauthProviderId.Microsoft,
                "vercel" => NeonAuthOauthProviderId.Vercel,
                _ => null,
            };
        }
    }
}