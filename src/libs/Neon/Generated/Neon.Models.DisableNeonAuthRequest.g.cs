
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DisableNeonAuthRequest
    {
        /// <summary>
        /// If true, deletes the `neon_auth` schema from the database<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_data")]
        public bool? DeleteData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisableNeonAuthRequest" /> class.
        /// </summary>
        /// <param name="deleteData">
        /// If true, deletes the `neon_auth` schema from the database<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisableNeonAuthRequest(
            bool? deleteData)
        {
            this.DeleteData = deleteData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisableNeonAuthRequest" /> class.
        /// </summary>
        public DisableNeonAuthRequest()
        {
        }
    }
}