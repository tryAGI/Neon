
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomDomainRegisterRequest
    {
        /// <summary>
        /// The custom domain to register (for example `dashboard.acme.com`).<br/>
        /// Case-insensitive; normalized to lowercase (a trailing root dot is<br/>
        /// stripped, so the 254-char bound admits a fully-qualified name whose<br/>
        /// normalized form is 253 chars). Neon-managed and internal hostnames are<br/>
        /// rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// The kind of branch entity to point the domain at. v1 supports only<br/>
        /// `function`; any other value is rejected with `invalid_entity_type`.<br/>
        /// Example: function
        /// </summary>
        /// <example>function</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// The target entity's identifier within the branch. For `function` this<br/>
        /// is the function slug (which must already exist on the branch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomainRegisterRequest" /> class.
        /// </summary>
        /// <param name="domain">
        /// The custom domain to register (for example `dashboard.acme.com`).<br/>
        /// Case-insensitive; normalized to lowercase (a trailing root dot is<br/>
        /// stripped, so the 254-char bound admits a fully-qualified name whose<br/>
        /// normalized form is 253 chars). Neon-managed and internal hostnames are<br/>
        /// rejected.
        /// </param>
        /// <param name="entityType">
        /// The kind of branch entity to point the domain at. v1 supports only<br/>
        /// `function`; any other value is rejected with `invalid_entity_type`.<br/>
        /// Example: function
        /// </param>
        /// <param name="entityId">
        /// The target entity's identifier within the branch. For `function` this<br/>
        /// is the function slug (which must already exist on the branch).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDomainRegisterRequest(
            string domain,
            string entityType,
            string entityId)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomainRegisterRequest" /> class.
        /// </summary>
        public CustomDomainRegisterRequest()
        {
        }

    }
}