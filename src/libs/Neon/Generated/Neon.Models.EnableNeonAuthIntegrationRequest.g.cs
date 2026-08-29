
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnableNeonAuthIntegrationRequest
    {
        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// Name of the database to enable Neon Auth on. When omitted, the integration uses the project's default database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_name")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableNeonAuthIntegrationRequest" /> class.
        /// </summary>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="databaseName">
        /// Name of the database to enable Neon Auth on. When omitted, the integration uses the project's default database.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnableNeonAuthIntegrationRequest(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string? databaseName)
        {
            this.AuthProvider = authProvider;
            this.DatabaseName = databaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableNeonAuthIntegrationRequest" /> class.
        /// </summary>
        public EnableNeonAuthIntegrationRequest()
        {
        }

    }
}