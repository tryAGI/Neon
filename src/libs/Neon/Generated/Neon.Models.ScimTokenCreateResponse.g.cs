
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScimTokenCreateResponse
    {
        /// <summary>
        /// The generated SCIM bearer token. Shown once — store it securely; it cannot be retrieved later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ScimToken ScimToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimTokenCreateResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The generated SCIM bearer token. Shown once — store it securely; it cannot be retrieved later.
        /// </param>
        /// <param name="scimToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimTokenCreateResponse(
            string token,
            global::Neon.ScimToken scimToken)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ScimToken = scimToken ?? throw new global::System.ArgumentNullException(nameof(scimToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimTokenCreateResponse" /> class.
        /// </summary>
        public ScimTokenCreateResponse()
        {
        }

    }
}