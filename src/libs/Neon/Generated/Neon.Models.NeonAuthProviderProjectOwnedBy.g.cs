
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthProviderProjectOwnedBy
    {
        /// <summary>
        /// 
        /// </summary>
        Neon,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthProviderProjectOwnedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthProviderProjectOwnedBy value)
        {
            return value switch
            {
                NeonAuthProviderProjectOwnedBy.Neon => "neon",
                NeonAuthProviderProjectOwnedBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthProviderProjectOwnedBy? ToEnum(string value)
        {
            return value switch
            {
                "neon" => NeonAuthProviderProjectOwnedBy.Neon,
                "user" => NeonAuthProviderProjectOwnedBy.User,
                _ => null,
            };
        }
    }
}