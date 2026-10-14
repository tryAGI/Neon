
#nullable enable

namespace Neon
{
    /// <summary>
    /// Confidential clients authenticate with a client secret. Public clients have no secret.
    /// </summary>
    public enum NeonAuthOAuthClientType
    {
        /// <summary>
        ///
        /// </summary>
        Confidential,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthOAuthClientTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthOAuthClientType value)
        {
            return value switch
            {
                NeonAuthOAuthClientType.Confidential => "confidential",
                NeonAuthOAuthClientType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthOAuthClientType? ToEnum(string value)
        {
            return value switch
            {
                "confidential" => NeonAuthOAuthClientType.Confidential,
                "public" => NeonAuthOAuthClientType.Public,
                _ => null,
            };
        }
    }
}