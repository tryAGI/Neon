
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchAiGateway
    {
        /// <summary>
        /// Always `true` in 200 responses. Present for forward compatibility,<br/>
        /// mirroring BranchStorage.enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The AI-gateway endpoint root for this branch — an OpenAI-compatible<br/>
        /// base URL. No dialect path is included; clients append the route<br/>
        /// (e.g. `/ai-gateway/openai/v1/responses`) themselves.<br/>
        /// Example: https://br-cool-moon-42-api.ai.c-2.local.neon.build
        /// </summary>
        /// <example>https://br-cool-moon-42-api.ai.c-2.local.neon.build</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAiGateway" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Always `true` in 200 responses. Present for forward compatibility,<br/>
        /// mirroring BranchStorage.enabled.
        /// </param>
        /// <param name="baseUrl">
        /// The AI-gateway endpoint root for this branch — an OpenAI-compatible<br/>
        /// base URL. No dialect path is included; clients append the route<br/>
        /// (e.g. `/ai-gateway/openai/v1/responses`) themselves.<br/>
        /// Example: https://br-cool-moon-42-api.ai.c-2.local.neon.build
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchAiGateway(
            bool enabled,
            string baseUrl)
        {
            this.Enabled = enabled;
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAiGateway" /> class.
        /// </summary>
        public BranchAiGateway()
        {
        }

    }
}