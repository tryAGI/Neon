
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonFunction
    {
        /// <summary>
        /// Opaque, stable function identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Branch-unique, lowercase DNS-label. Forms the invocation URL's host together with the branch id. Immutable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Free-form display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL at which the function is invoked. The host carries `&lt;branch_id&gt;-&lt;slug&gt;` as its first DNS label under a Neon-managed functions domain, and the URL ends with a trailing slash so paths concatenate onto it. Empty string when the function has no servable invoke host (e.g. a deployment without an invocation front-door).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationUrl { get; set; }

        /// <summary>
        /// The most recent deployment, regardless of build status. It may<br/>
        /// still be building or it may have failed. Omitted until the first<br/>
        /// deployment is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_deployment")]
        public global::Neon.NeonFunctionDeployment? CurrentDeployment { get; set; }

        /// <summary>
        /// The most recent deployment whose build completed successfully.<br/>
        /// This is the deployment that serves invocations. Omitted until a<br/>
        /// deployment succeeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_deployment")]
        public global::Neon.NeonFunctionDeployment? ActiveDeployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunction" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque, stable function identifier.
        /// </param>
        /// <param name="slug">
        /// Branch-unique, lowercase DNS-label. Forms the invocation URL's host together with the branch id. Immutable.
        /// </param>
        /// <param name="name">
        /// Free-form display name.
        /// </param>
        /// <param name="invocationUrl">
        /// URL at which the function is invoked. The host carries `&lt;branch_id&gt;-&lt;slug&gt;` as its first DNS label under a Neon-managed functions domain, and the URL ends with a trailing slash so paths concatenate onto it. Empty string when the function has no servable invoke host (e.g. a deployment without an invocation front-door).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="currentDeployment">
        /// The most recent deployment, regardless of build status. It may<br/>
        /// still be building or it may have failed. Omitted until the first<br/>
        /// deployment is created.
        /// </param>
        /// <param name="activeDeployment">
        /// The most recent deployment whose build completed successfully.<br/>
        /// This is the deployment that serves invocations. Omitted until a<br/>
        /// deployment succeeds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonFunction(
            string id,
            string slug,
            string name,
            string invocationUrl,
            string createdAt,
            global::Neon.NeonFunctionDeployment? currentDeployment,
            global::Neon.NeonFunctionDeployment? activeDeployment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InvocationUrl = invocationUrl ?? throw new global::System.ArgumentNullException(nameof(invocationUrl));
            this.CurrentDeployment = currentDeployment;
            this.ActiveDeployment = activeDeployment;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunction" /> class.
        /// </summary>
        public NeonFunction()
        {
        }

    }
}