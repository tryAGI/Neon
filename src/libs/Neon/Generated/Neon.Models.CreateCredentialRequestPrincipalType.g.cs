
#nullable enable

namespace Neon
{
    /// <summary>
    /// Principal type for the credential. Only `user` is customer-managed<br/>
    /// and accepted here. `function` and `system` credentials are<br/>
    /// platform-internal (e.g. function-serve auto-mint, presign signer)<br/>
    /// and are never issued through the customer-facing API.
    /// </summary>
    public enum CreateCredentialRequestPrincipalType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCredentialRequestPrincipalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCredentialRequestPrincipalType value)
        {
            return value switch
            {
                CreateCredentialRequestPrincipalType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCredentialRequestPrincipalType? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateCredentialRequestPrincipalType.User,
                _ => null,
            };
        }
    }
}