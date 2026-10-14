
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListNeonAuthOAuthClientsResponse
    {
        /// <summary>
        /// OAuth clients registered for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.NeonAuthOAuthClient> Clients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNeonAuthOAuthClientsResponse" /> class.
        /// </summary>
        /// <param name="clients">
        /// OAuth clients registered for the branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListNeonAuthOAuthClientsResponse(
            global::System.Collections.Generic.IList<global::Neon.NeonAuthOAuthClient> clients)
        {
            this.Clients = clients ?? throw new global::System.ArgumentNullException(nameof(clients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNeonAuthOAuthClientsResponse" /> class.
        /// </summary>
        public ListNeonAuthOAuthClientsResponse()
        {
        }

    }
}