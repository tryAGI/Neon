
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount> AuthAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// DEPRECATED. Use `email` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ProjectsLimit { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_seconds_limit")]
        public long? ComputeSecondsLimit { get; set; }

        /// <summary>
        /// 
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
        /// <param name="authAccounts"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="image"></param>
        /// <param name="login">
        /// DEPRECATED. Use `email` field.
        /// </param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="projectsLimit"></param>
        /// <param name="branchesLimit"></param>
        /// <param name="maxAutoscalingLimit">
        /// The maximum autoscaling limit in Compute Units.<br/>
        /// A value of 0 indicates no limit is configured.
        /// </param>
        /// <param name="plan"></param>
        /// <param name="billingAccount"></param>
        /// <param name="computeSecondsLimit"></param>
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