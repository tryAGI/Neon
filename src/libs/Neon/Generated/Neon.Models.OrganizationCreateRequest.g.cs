
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.OrganizationCreateRequestOrganization Organization { get; set; }

        /// <summary>
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BillingSubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Whether to transfer credits from the user account to the newly created organization account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_credits")]
        public bool? TransferCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateRequest" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="subscriptionType">
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </param>
        /// <param name="transferCredits">
        /// Whether to transfer credits from the user account to the newly created organization account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreateRequest(
            global::Neon.OrganizationCreateRequestOrganization organization,
            global::Neon.BillingSubscriptionType subscriptionType,
            bool? transferCredits)
        {
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.SubscriptionType = subscriptionType;
            this.TransferCredits = transferCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateRequest" /> class.
        /// </summary>
        public OrganizationCreateRequest()
        {
        }
    }
}