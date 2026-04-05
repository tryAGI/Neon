
#nullable enable

namespace Neon
{
    /// <summary>
    /// The list of configured JWKS definitions for a project
    /// </summary>
    public sealed partial class ProjectJWKSResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Jwks> Jwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectJWKSResponse" /> class.
        /// </summary>
        /// <param name="jwks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectJWKSResponse(
            global::System.Collections.Generic.IList<global::Neon.Jwks> jwks)
        {
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectJWKSResponse" /> class.
        /// </summary>
        public ProjectJWKSResponse()
        {
        }
    }
}