
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectOwnerData
    {
        /// <summary>
        /// Email address of the project owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Display name of the project owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Maximum number of branches the owner is allowed to create across their projects.
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
        /// <param name="email">
        /// Email address of the project owner.
        /// </param>
        /// <param name="name">
        /// Display name of the project owner.
        /// </param>
        /// <param name="branchesLimit">
        /// Maximum number of branches the owner is allowed to create across their projects.
        /// </param>
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