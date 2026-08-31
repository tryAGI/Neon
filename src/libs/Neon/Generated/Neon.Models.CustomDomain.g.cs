
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomDomain
    {
        /// <summary>
        /// The registered custom domain (normalized, lowercase).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// The kind of branch entity the domain targets. Possible values:<br/>
        /// `function` (v1 supports only `function`). Not an `enum`: new values may<br/>
        /// ship in later spec versions — treat any undocumented value as unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// The target entity's identifier within the branch. For `function` this<br/>
        /// is the function slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// The hostname the customer must point their custom domain at with a<br/>
        /// CNAME record. Empty when the serving region has no custom-domains<br/>
        /// front door configured. This is the only activation input: point DNS<br/>
        /// here and the domain goes live once a certificate is issued on the first<br/>
        /// request. (v1 has no status/lifecycle field.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CnameTarget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomain" /> class.
        /// </summary>
        /// <param name="domain">
        /// The registered custom domain (normalized, lowercase).
        /// </param>
        /// <param name="entityType">
        /// The kind of branch entity the domain targets. Possible values:<br/>
        /// `function` (v1 supports only `function`). Not an `enum`: new values may<br/>
        /// ship in later spec versions — treat any undocumented value as unknown.
        /// </param>
        /// <param name="entityId">
        /// The target entity's identifier within the branch. For `function` this<br/>
        /// is the function slug.
        /// </param>
        /// <param name="cnameTarget">
        /// The hostname the customer must point their custom domain at with a<br/>
        /// CNAME record. Empty when the serving region has no custom-domains<br/>
        /// front door configured. This is the only activation input: point DNS<br/>
        /// here and the domain goes live once a certificate is issued on the first<br/>
        /// request. (v1 has no status/lifecycle field.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDomain(
            string domain,
            string entityType,
            string entityId,
            string cnameTarget)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.CnameTarget = cnameTarget ?? throw new global::System.ArgumentNullException(nameof(cnameTarget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomain" /> class.
        /// </summary>
        public CustomDomain()
        {
        }

    }
}