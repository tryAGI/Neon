
#nullable enable

namespace Neon
{
    /// <summary>
    /// Always `user`: only customer-managed credentials are rotatable<br/>
    /// through this endpoint.
    /// </summary>
    public enum RotateCredentialResponsePrincipalType
    {
        /// <summary>
        /// only customer-managed credentials are rotatable
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateCredentialResponsePrincipalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateCredentialResponsePrincipalType value)
        {
            return value switch
            {
                RotateCredentialResponsePrincipalType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateCredentialResponsePrincipalType? ToEnum(string value)
        {
            return value switch
            {
                "user" => RotateCredentialResponsePrincipalType.User,
                _ => null,
            };
        }
    }
}