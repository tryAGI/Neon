
#nullable enable

namespace Neon
{
    /// <summary>
    /// How this Data API verifies JWTs, as recorded by the last create that named a provider. `neon_auth` verifies Neon Auth tokens; `external` verifies tokens from a third-party identity provider via `jwks_url`. Absent when no provider is recorded: the Data API was created before providers were recorded, or it was created without naming one. Treat an absent value as unknown and fall back to the branch's Neon Auth state (`GET /projects/{project_id}/branches/{branch_id}/auth`). The value can differ from the current setup (for example, a JWKS added later), and it is also absent in responses served from the state cache while the compute is suspended. A child branch inherits its parent's Data API and reports the parent's provider.
    /// </summary>
    public enum DataAPIReponseAuthProvider
    {
        /// <summary>
        /// the Data API was created before providers were recorded, or it was created without naming one. Treat an absent value as unknown and fall back to the branch's Neon Auth state (`GET /projects/{project_id}/branches/{branch_id}/auth`). The value can differ from the current setup (for example, a JWKS added later), and it is also absent in responses served from the state cache while the compute is suspended. A child branch inherits its parent's Data API and reports the parent's provider.
        /// </summary>
        External,
        /// <summary>
        /// the Data API was created before providers were recorded, or it was created without naming one. Treat an absent value as unknown and fall back to the branch's Neon Auth state (`GET /projects/{project_id}/branches/{branch_id}/auth`). The value can differ from the current setup (for example, a JWKS added later), and it is also absent in responses served from the state cache while the compute is suspended. A child branch inherits its parent's Data API and reports the parent's provider.
        /// </summary>
        NeonAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataAPIReponseAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataAPIReponseAuthProvider value)
        {
            return value switch
            {
                DataAPIReponseAuthProvider.External => "external",
                DataAPIReponseAuthProvider.NeonAuth => "neon_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataAPIReponseAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "external" => DataAPIReponseAuthProvider.External,
                "neon_auth" => DataAPIReponseAuthProvider.NeonAuth,
                _ => null,
            };
        }
    }
}