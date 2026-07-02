
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchAiGatewayNotEnabled
    {
        /// <summary>
        /// Example: AI_GATEWAY_NOT_ENABLED
        /// </summary>
        /// <example>AI_GATEWAY_NOT_ENABLED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable reason why the AI gateway is unavailable:<br/>
        /// - `ai_gateway_unavailable`: the project's region/cell has no AI gateway configured.<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BranchAiGatewayNotEnabledReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BranchAiGatewayNotEnabledReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAiGatewayNotEnabled" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: AI_GATEWAY_NOT_ENABLED
        /// </param>
        /// <param name="message"></param>
        /// <param name="reason">
        /// Machine-readable reason why the AI gateway is unavailable:<br/>
        /// - `ai_gateway_unavailable`: the project's region/cell has no AI gateway configured.<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchAiGatewayNotEnabled(
            string code,
            string message,
            global::Neon.BranchAiGatewayNotEnabledReason reason)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAiGatewayNotEnabled" /> class.
        /// </summary>
        public BranchAiGatewayNotEnabled()
        {
        }

    }
}