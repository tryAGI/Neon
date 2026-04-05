
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneralError
    {
        /// <summary>
        /// Unique identifier for the request, useful for debugging.<br/>
        /// You can set this value manually by including an `X-Request-ID` header in the request. If not provided, the value will be generated automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message">
        /// Error message
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request, useful for debugging.<br/>
        /// You can set this value manually by including an `X-Request-ID` header in the request. If not provided, the value will be generated automatically.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneralError(
            string code,
            string message,
            string? requestId)
        {
            this.RequestId = requestId;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralError" /> class.
        /// </summary>
        public GeneralError()
        {
        }
    }
}