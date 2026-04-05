
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryAuthenticationApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Optional. Custom header name for the API key. If not specified, defaults to "X-API-Key".<br/>
        /// This allows using custom header names like "Authorization", "X-Custom-Key", etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryAuthenticationApiKey" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="headerName">
        /// Optional. Custom header name for the API key. If not specified, defaults to "X-API-Key".<br/>
        /// This allows using custom header names like "Authorization", "X-Custom-Key", etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryAuthenticationApiKey(
            string key,
            string? headerName)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.HeaderName = headerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryAuthenticationApiKey" /> class.
        /// </summary>
        public TelemetryAuthenticationApiKey()
        {
        }
    }
}