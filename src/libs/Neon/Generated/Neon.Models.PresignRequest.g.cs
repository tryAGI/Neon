
#nullable enable

namespace Neon
{
    /// <summary>
    /// Options for the presigned URL. The `operation` selects upload (`PUT`)<br/>
    /// or download (`GET`); the remaining fields are optional.
    /// </summary>
    public sealed partial class PresignRequest
    {
        /// <summary>
        /// The transfer direction. `upload` returns a presigned `PUT` URL;<br/>
        /// `download` returns a presigned `GET` URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.PresignRequestOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.PresignRequestOperation Operation { get; set; }

        /// <summary>
        /// The `Content-Type` to bind into the signed request. Only meaningful<br/>
        /// for `upload`: when set, the caller MUST send the same `Content-Type`<br/>
        /// header on the `PUT`, and the value is echoed back in the response<br/>
        /// `headers`. Ignored for `download`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// How long the presigned URL stays valid, in seconds. Defaults to 900<br/>
        /// (15 minutes); capped at 604800 (7 days).<br/>
        /// Default Value: 900
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public long? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignRequest" /> class.
        /// </summary>
        /// <param name="operation">
        /// The transfer direction. `upload` returns a presigned `PUT` URL;<br/>
        /// `download` returns a presigned `GET` URL.
        /// </param>
        /// <param name="contentType">
        /// The `Content-Type` to bind into the signed request. Only meaningful<br/>
        /// for `upload`: when set, the caller MUST send the same `Content-Type`<br/>
        /// header on the `PUT`, and the value is echoed back in the response<br/>
        /// `headers`. Ignored for `download`.
        /// </param>
        /// <param name="expiresInSeconds">
        /// How long the presigned URL stays valid, in seconds. Defaults to 900<br/>
        /// (15 minutes); capped at 604800 (7 days).<br/>
        /// Default Value: 900
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignRequest(
            global::Neon.PresignRequestOperation operation,
            string? contentType,
            long? expiresInSeconds)
        {
            this.Operation = operation;
            this.ContentType = contentType;
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignRequest" /> class.
        /// </summary>
        public PresignRequest()
        {
        }

    }
}