
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListNeonAuthOauthProvidersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider> Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNeonAuthOauthProvidersResponse" /> class.
        /// </summary>
        /// <param name="providers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListNeonAuthOauthProvidersResponse(
            global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider> providers)
        {
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNeonAuthOauthProvidersResponse" /> class.
        /// </summary>
        public ListNeonAuthOauthProvidersResponse()
        {
        }
    }
}