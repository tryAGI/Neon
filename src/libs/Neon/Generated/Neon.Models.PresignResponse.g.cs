
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignResponse
    {
        /// <summary>
        /// The presigned URL. Transfer the object bytes by issuing<br/>
        /// `method url` with the returned `headers`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The HTTP method to use against `url`: `PUT` for an upload,<br/>
        /// `GET` for a download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// Headers the caller MUST send verbatim on the request (e.g.<br/>
        /// `Content-Type` when it was signed on an upload). May be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// When the presigned URL stops being valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The presigned URL. Transfer the object bytes by issuing<br/>
        /// `method url` with the returned `headers`.
        /// </param>
        /// <param name="method">
        /// The HTTP method to use against `url`: `PUT` for an upload,<br/>
        /// `GET` for a download.
        /// </param>
        /// <param name="headers">
        /// Headers the caller MUST send verbatim on the request (e.g.<br/>
        /// `Content-Type` when it was signed on an upload). May be empty.
        /// </param>
        /// <param name="expiresAt">
        /// When the presigned URL stops being valid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignResponse(
            string url,
            string method,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::System.DateTime expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignResponse" /> class.
        /// </summary>
        public PresignResponse()
        {
        }

    }
}