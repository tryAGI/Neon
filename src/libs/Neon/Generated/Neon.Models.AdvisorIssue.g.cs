
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdvisorIssue
    {
        /// <summary>
        /// Unique identifier for the issue type<br/>
        /// Example: rls_disabled_in_public
        /// </summary>
        /// <example>rls_disabled_in_public</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable title<br/>
        /// Example: RLS Disabled in Public
        /// </summary>
        /// <example>RLS Disabled in Public</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Severity level of the issue<br/>
        /// Example: ERROR
        /// </summary>
        /// <example>ERROR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Level { get; set; }

        /// <summary>
        /// Whether this issue affects external API exposure or is internal only<br/>
        /// Example: EXTERNAL
        /// </summary>
        /// <example>EXTERNAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.AdvisorIssueFacingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.AdvisorIssueFacing Facing { get; set; }

        /// <summary>
        /// Categories this issue belongs to<br/>
        /// Example: [SECURITY]
        /// </summary>
        /// <example>[SECURITY]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.AdvisorCategory> Categories { get; set; }

        /// <summary>
        /// Detailed description of what this check detects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Specific details about this instance of the issue<br/>
        /// Example: Table `public.users` is public, but RLS has not been enabled.
        /// </summary>
        /// <example>Table `public.users` is public, but RLS has not been enabled.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// URL to documentation on how to fix this issue<br/>
        /// Example: https://neon.tech/docs/guides/database-advisor
        /// </summary>
        /// <example>https://neon.tech/docs/guides/database-advisor</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remediation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Remediation { get; set; }

        /// <summary>
        /// Additional context-specific metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Unique key for caching this issue result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorIssue" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique identifier for the issue type<br/>
        /// Example: rls_disabled_in_public
        /// </param>
        /// <param name="title">
        /// Human-readable title<br/>
        /// Example: RLS Disabled in Public
        /// </param>
        /// <param name="level">
        /// Severity level of the issue<br/>
        /// Example: ERROR
        /// </param>
        /// <param name="facing">
        /// Whether this issue affects external API exposure or is internal only<br/>
        /// Example: EXTERNAL
        /// </param>
        /// <param name="categories">
        /// Categories this issue belongs to<br/>
        /// Example: [SECURITY]
        /// </param>
        /// <param name="description">
        /// Detailed description of what this check detects
        /// </param>
        /// <param name="detail">
        /// Specific details about this instance of the issue<br/>
        /// Example: Table `public.users` is public, but RLS has not been enabled.
        /// </param>
        /// <param name="remediation">
        /// URL to documentation on how to fix this issue<br/>
        /// Example: https://neon.tech/docs/guides/database-advisor
        /// </param>
        /// <param name="metadata">
        /// Additional context-specific metadata
        /// </param>
        /// <param name="cacheKey">
        /// Unique key for caching this issue result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorIssue(
            string name,
            string title,
            string level,
            global::Neon.AdvisorIssueFacing facing,
            global::System.Collections.Generic.IList<global::Neon.AdvisorCategory> categories,
            string description,
            string detail,
            string remediation,
            object metadata,
            string cacheKey)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Level = level ?? throw new global::System.ArgumentNullException(nameof(level));
            this.Facing = facing;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Remediation = remediation ?? throw new global::System.ArgumentNullException(nameof(remediation));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CacheKey = cacheKey ?? throw new global::System.ArgumentNullException(nameof(cacheKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorIssue" /> class.
        /// </summary>
        public AdvisorIssue()
        {
        }
    }
}