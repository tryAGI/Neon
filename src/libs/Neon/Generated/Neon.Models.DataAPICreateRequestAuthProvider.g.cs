
#nullable enable

namespace Neon
{
    /// <summary>
    /// The authentication provider to use for the Neon Data API
    /// </summary>
    public enum DataAPICreateRequestAuthProvider
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        NeonAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataAPICreateRequestAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataAPICreateRequestAuthProvider value)
        {
            return value switch
            {
                DataAPICreateRequestAuthProvider.External => "external",
                DataAPICreateRequestAuthProvider.NeonAuth => "neon_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataAPICreateRequestAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "external" => DataAPICreateRequestAuthProvider.External,
                "neon_auth" => DataAPICreateRequestAuthProvider.NeonAuth,
                _ => null,
            };
        }
    }
}