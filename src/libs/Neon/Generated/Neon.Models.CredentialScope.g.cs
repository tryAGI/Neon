
#nullable enable

namespace Neon
{
    /// <summary>
    /// A single capability a credential may exercise. A credential is granted<br/>
    /// a set of these; it may only perform actions explicitly listed in its<br/>
    /// scopes.
    /// </summary>
    public enum CredentialScope
    {
        /// <summary>
        /// 
        /// </summary>
        AiGateway_invoke,
        /// <summary>
        /// 
        /// </summary>
        Functions_invoke,
        /// <summary>
        /// 
        /// </summary>
        Storage_read,
        /// <summary>
        /// 
        /// </summary>
        Storage_write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialScope value)
        {
            return value switch
            {
                CredentialScope.AiGateway_invoke => "ai_gateway:invoke",
                CredentialScope.Functions_invoke => "functions:invoke",
                CredentialScope.Storage_read => "storage:read",
                CredentialScope.Storage_write => "storage:write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialScope? ToEnum(string value)
        {
            return value switch
            {
                "ai_gateway:invoke" => CredentialScope.AiGateway_invoke,
                "functions:invoke" => CredentialScope.Functions_invoke,
                "storage:read" => CredentialScope.Storage_read,
                "storage:write" => CredentialScope.Storage_write,
                _ => null,
            };
        }
    }
}