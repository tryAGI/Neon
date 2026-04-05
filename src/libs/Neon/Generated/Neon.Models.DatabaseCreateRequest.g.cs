
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatabaseCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.DatabaseCreateRequestDatabase Database { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseCreateRequest" /> class.
        /// </summary>
        /// <param name="database"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabaseCreateRequest(
            global::Neon.DatabaseCreateRequestDatabase database)
        {
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseCreateRequest" /> class.
        /// </summary>
        public DatabaseCreateRequest()
        {
        }
    }
}