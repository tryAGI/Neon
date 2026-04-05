
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectOwnerData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BranchesLimit { get; set; }

        /// <summary>
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BillingSubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectOwnerData" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="branchesLimit"></param>
        /// <param name="subscriptionType">
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectOwnerData(
            string email,
            string name,
            int branchesLimit,
            global::Neon.BillingSubscriptionType subscriptionType)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BranchesLimit = branchesLimit;
            this.SubscriptionType = subscriptionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectOwnerData" /> class.
        /// </summary>
        public ProjectOwnerData()
        {
        }
    }
}