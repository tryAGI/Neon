
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthOauthProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Shared,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthOauthProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthOauthProviderType value)
        {
            return value switch
            {
                NeonAuthOauthProviderType.Shared => "shared",
                NeonAuthOauthProviderType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthOauthProviderType? ToEnum(string value)
        {
            return value switch
            {
                "shared" => NeonAuthOauthProviderType.Shared,
                "standard" => NeonAuthOauthProviderType.Standard,
                _ => null,
            };
        }
    }
}