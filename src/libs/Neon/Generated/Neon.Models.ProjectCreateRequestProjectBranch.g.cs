
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectCreateRequestProjectBranch
    {
        /// <summary>
        /// The default branch name. If not specified, the default branch name, `main`, will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The role name. If not specified, the default role name, `{database_name}_owner`, will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// The database name. If not specified, the default database name, `neondb`, will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_name")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Annotation properties.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </summary>
        /// <example>{"github-commit-ref":"github-branch-name"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.Dictionary<string, string>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequestProjectBranch" /> class.
        /// </summary>
        /// <param name="name">
        /// The default branch name. If not specified, the default branch name, `main`, will be used.
        /// </param>
        /// <param name="roleName">
        /// The role name. If not specified, the default role name, `{database_name}_owner`, will be used.
        /// </param>
        /// <param name="databaseName">
        /// The database name. If not specified, the default database name, `neondb`, will be used.
        /// </param>
        /// <param name="annotations">
        /// Annotation properties.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreateRequestProjectBranch(
            string? name,
            string? roleName,
            string? databaseName,
            global::System.Collections.Generic.Dictionary<string, string>? annotations)
        {
            this.Name = name;
            this.RoleName = roleName;
            this.DatabaseName = databaseName;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequestProjectBranch" /> class.
        /// </summary>
        public ProjectCreateRequestProjectBranch()
        {
        }
    }
}