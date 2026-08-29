
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CurrentUserInfoResponse
    {
        /// <summary>
        /// Control plane observes active endpoints of a user this amount of wall-clock time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_seconds_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ActiveSecondsLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_account")]
        public global::Neon.BillingAccount? BillingAccount { get; set; }

        /// <summary>
        /// Authentication provider accounts linked to the current user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount> AuthAccounts { get; set; }

        /// <summary>
        /// Email address of the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The Neon user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// URL of the user's profile avatar image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Deprecated. Use the `email` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// First name of the current user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Last name of the current user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// Maximum number of projects the account is allowed to create under the current plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ProjectsLimit { get; set; }

        /// <summary>
        /// Maximum number of branches allowed for the account under the current plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BranchesLimit { get; set; }

        /// <summary>
        /// The maximum autoscaling limit in Compute Units.<br/>
        /// A value of 0 indicates no limit is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_autoscaling_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAutoscalingLimit { get; set; }

        /// <summary>
        /// Maximum Postgres compute time, in seconds, allowed under the account's current plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_seconds_limit")]
        public long? ComputeSecondsLimit { get; set; }

        /// <summary>
        /// Current billing plan for the user's account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserInfoResponse" /> class.
        /// </summary>
        /// <param name="activeSecondsLimit">
        /// Control plane observes active endpoints of a user this amount of wall-clock time.
        /// </param>
        /// <param name="authAccounts">
        /// Authentication provider accounts linked to the current user.
        /// </param>
        /// <param name="email">
        /// Email address of the authenticated user.
        /// </param>
        /// <param name="id">
        /// The Neon user ID.
        /// </param>
        /// <param name="image">
        /// URL of the user's profile avatar image.
        /// </param>
        /// <param name="login">
        /// Deprecated. Use the `email` field.
        /// </param>
        /// <param name="name">
        /// First name of the current user.
        /// </param>
        /// <param name="lastName">
        /// Last name of the current user.
        /// </param>
        /// <param name="projectsLimit">
        /// Maximum number of projects the account is allowed to create under the current plan.
        /// </param>
        /// <param name="branchesLimit">
        /// Maximum number of branches allowed for the account under the current plan.
        /// </param>
        /// <param name="maxAutoscalingLimit">
        /// The maximum autoscaling limit in Compute Units.<br/>
        /// A value of 0 indicates no limit is configured.
        /// </param>
        /// <param name="plan">
        /// Current billing plan for the user's account.
        /// </param>
        /// <param name="billingAccount"></param>
        /// <param name="computeSecondsLimit">
        /// Maximum Postgres compute time, in seconds, allowed under the account's current plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentUserInfoResponse(
            long activeSecondsLimit,
            global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount> authAccounts,
            string email,
            string id,
            string image,
            string login,
            string name,
            string lastName,
            long projectsLimit,
            long branchesLimit,
            double maxAutoscalingLimit,
            string plan,
            global::Neon.BillingAccount? billingAccount,
            long? computeSecondsLimit)
        {
            this.ActiveSecondsLimit = activeSecondsLimit;
            this.BillingAccount = billingAccount;
            this.AuthAccounts = authAccounts ?? throw new global::System.ArgumentNullException(nameof(authAccounts));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.ProjectsLimit = projectsLimit;
            this.BranchesLimit = branchesLimit;
            this.MaxAutoscalingLimit = maxAutoscalingLimit;
            this.ComputeSecondsLimit = computeSecondsLimit;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserInfoResponse" /> class.
        /// </summary>
        public CurrentUserInfoResponse()
        {
        }

    }
}