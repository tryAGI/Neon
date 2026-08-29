
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthCreateAuthProviderSDKKeysRequest
    {
        /// <summary>
        /// The Neon project ID. Returned as `id` from `GET /projects`.<br/>
        /// Example: wispy-forest-12345678
        /// </summary>
        /// <example>wispy-forest-12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateAuthProviderSDKKeysRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Neon project ID. Returned as `id` from `GET /projects`.<br/>
        /// Example: wispy-forest-12345678
        /// </param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthCreateAuthProviderSDKKeysRequest(
            string projectId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AuthProvider = authProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateAuthProviderSDKKeysRequest" /> class.
        /// </summary>
        public NeonAuthCreateAuthProviderSDKKeysRequest()
        {
        }

    }
}