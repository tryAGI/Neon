
#nullable enable

namespace Neon
{
    /// <summary>
    /// A single capability a credential actually carries, as reported by<br/>
    /// responses that describe an existing credential.<br/>
    /// This set is a superset of `CredentialScope` (the requestable set)<br/>
    /// because a credential's scopes are not limited to what this API offers:<br/>
    /// the platform accepts additional scopes for customer-managed (`user`)<br/>
    /// credentials, so one may exist on your branch that was not issued<br/>
    /// through this endpoint. Responses must be able to report such a<br/>
    /// credential rather than fail to describe it — a client that rejected<br/>
    /// the value would, on rotate, discard the replacement secret after the<br/>
    /// rotation had already committed. Treat unknown values as opaque.
    /// </summary>
    public enum GrantedCredentialScope
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
        /// <summary>
        ///
        /// </summary>
        Telemetry_write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GrantedCredentialScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrantedCredentialScope value)
        {
            return value switch
            {
                GrantedCredentialScope.AiGateway_invoke => "ai_gateway:invoke",
                GrantedCredentialScope.Functions_invoke => "functions:invoke",
                GrantedCredentialScope.Storage_read => "storage:read",
                GrantedCredentialScope.Storage_write => "storage:write",
                GrantedCredentialScope.Telemetry_write => "telemetry:write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrantedCredentialScope? ToEnum(string value)
        {
            return value switch
            {
                "ai_gateway:invoke" => GrantedCredentialScope.AiGateway_invoke,
                "functions:invoke" => GrantedCredentialScope.Functions_invoke,
                "storage:read" => GrantedCredentialScope.Storage_read,
                "storage:write" => GrantedCredentialScope.Storage_write,
                "telemetry:write" => GrantedCredentialScope.Telemetry_write,
                _ => null,
            };
        }
    }
}