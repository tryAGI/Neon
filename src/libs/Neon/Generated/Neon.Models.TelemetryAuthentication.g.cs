
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer_token")]
        public global::Neon.TelemetryAuthenticationBearerToken? BearerToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic")]
        public global::Neon.TelemetryAuthenticationBasic? Basic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Neon.TelemetryAuthenticationApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryAuthentication" /> class.
        /// </summary>
        /// <param name="bearerToken"></param>
        /// <param name="basic"></param>
        /// <param name="apiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryAuthentication(
            global::Neon.TelemetryAuthenticationBearerToken? bearerToken,
            global::Neon.TelemetryAuthenticationBasic? basic,
            global::Neon.TelemetryAuthenticationApiKey? apiKey)
        {
            this.BearerToken = bearerToken;
            this.Basic = basic;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryAuthentication" /> class.
        /// </summary>
        public TelemetryAuthentication()
        {
        }
    }
}