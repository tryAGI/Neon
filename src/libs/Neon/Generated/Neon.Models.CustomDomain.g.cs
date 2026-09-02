
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
        /// front door configured. This is the activation input: point DNS here<br/>
        /// and the domain goes live (see `status`) once a certificate is issued<br/>
        /// on the first request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CnameTarget { get; set; }

        /// <summary>
        /// The domain's current validity, computed by a background check:<br/>
        /// `pending` (still converging — point your CNAME at `cname_target` and<br/>
        /// wait), `active` (live: DNS resolves to the edge, the CA is authorized,<br/>
        /// and routing is published), or `error` (a fixable problem — see<br/>
        /// `status_reason`). Not an `enum`: treat any undocumented value as<br/>
        /// unknown. May be absent briefly right after registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The DNS + CAA portion of the check: `pending` (no records yet), `ok`<br/>
        /// (resolves to our edge and the CA is authorized), `misconfigured` (your<br/>
        /// CNAME does not resolve to our edge), or `caa_blocked` (your CAA records<br/>
        /// forbid Let's Encrypt). Not an `enum`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dns_status")]
        public string? DnsStatus { get; set; }

        /// <summary>
        /// Whether Neon's internal routing for the domain is published:<br/>
        /// `pending`, `present`, or `missing`. `missing` is an internal fault<br/>
        /// surfaced for support. Not an `enum`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binding_status")]
        public string? BindingStatus { get; set; }

        /// <summary>
        /// A short, stable machine-readable reason for a non-active `status`<br/>
        /// (e.g. `cname-not-pointing-at-edge`, `caa-blocks-lets-encrypt`,<br/>
        /// `binding-missing`), suitable for keying an actionable hint. Empty when<br/>
        /// active or pending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_reason")]
        public string? StatusReason { get; set; }

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
        /// front door configured. This is the activation input: point DNS here<br/>
        /// and the domain goes live (see `status`) once a certificate is issued<br/>
        /// on the first request.
        /// </param>
        /// <param name="status">
        /// The domain's current validity, computed by a background check:<br/>
        /// `pending` (still converging — point your CNAME at `cname_target` and<br/>
        /// wait), `active` (live: DNS resolves to the edge, the CA is authorized,<br/>
        /// and routing is published), or `error` (a fixable problem — see<br/>
        /// `status_reason`). Not an `enum`: treat any undocumented value as<br/>
        /// unknown. May be absent briefly right after registration.
        /// </param>
        /// <param name="dnsStatus">
        /// The DNS + CAA portion of the check: `pending` (no records yet), `ok`<br/>
        /// (resolves to our edge and the CA is authorized), `misconfigured` (your<br/>
        /// CNAME does not resolve to our edge), or `caa_blocked` (your CAA records<br/>
        /// forbid Let's Encrypt). Not an `enum`.
        /// </param>
        /// <param name="bindingStatus">
        /// Whether Neon's internal routing for the domain is published:<br/>
        /// `pending`, `present`, or `missing`. `missing` is an internal fault<br/>
        /// surfaced for support. Not an `enum`.
        /// </param>
        /// <param name="statusReason">
        /// A short, stable machine-readable reason for a non-active `status`<br/>
        /// (e.g. `cname-not-pointing-at-edge`, `caa-blocks-lets-encrypt`,<br/>
        /// `binding-missing`), suitable for keying an actionable hint. Empty when<br/>
        /// active or pending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDomain(
            string domain,
            string entityType,
            string entityId,
            string cnameTarget,
            string? status,
            string? dnsStatus,
            string? bindingStatus,
            string? statusReason)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.CnameTarget = cnameTarget ?? throw new global::System.ArgumentNullException(nameof(cnameTarget));
            this.Status = status;
            this.DnsStatus = dnsStatus;
            this.BindingStatus = bindingStatus;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomain" /> class.
        /// </summary>
        public CustomDomain()
        {
        }

    }
}