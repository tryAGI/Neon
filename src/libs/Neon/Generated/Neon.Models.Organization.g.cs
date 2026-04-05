
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// A timestamp indicting when the organization was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Organizations created via the Console or the API are managed by `console`.<br/>
        /// Organizations created by other methods can't be deleted via the Console or the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManagedBy { get; set; }

        /// <summary>
        /// A timestamp indicating when the organization was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// If true, allow account to mark projects as HIPAA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_hipaa_projects")]
        public bool? AllowHipaaProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="handle"></param>
        /// <param name="plan"></param>
        /// <param name="createdAt">
        /// A timestamp indicting when the organization was created
        /// </param>
        /// <param name="managedBy">
        /// Organizations created via the Console or the API are managed by `console`.<br/>
        /// Organizations created by other methods can't be deleted via the Console or the API.
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the organization was updated
        /// </param>
        /// <param name="allowHipaaProjects">
        /// If true, allow account to mark projects as HIPAA
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            string id,
            string name,
            string handle,
            string plan,
            global::System.DateTime createdAt,
            string managedBy,
            global::System.DateTime updatedAt,
            bool? allowHipaaProjects)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.CreatedAt = createdAt;
            this.ManagedBy = managedBy ?? throw new global::System.ArgumentNullException(nameof(managedBy));
            this.UpdatedAt = updatedAt;
            this.AllowHipaaProjects = allowHipaaProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}