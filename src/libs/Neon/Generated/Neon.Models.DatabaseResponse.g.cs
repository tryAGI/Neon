
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatabaseResponse
    {
        /// <summary>
        /// Example: {"id":834686,"branch_id":"br-wispy-meadow-118737","name":"neondb","owner_name":"casey","created_at":"2022-11-30T18:25:15Z","updated_at":"2022-11-30T18:25:15Z"}
        /// </summary>
        /// <example>{"id":834686,"branch_id":"br-wispy-meadow-118737","name":"neondb","owner_name":"casey","created_at":"2022-11-30T18:25:15Z","updated_at":"2022-11-30T18:25:15Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Database Database { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseResponse" /> class.
        /// </summary>
        /// <param name="database">
        /// Example: {"id":834686,"branch_id":"br-wispy-meadow-118737","name":"neondb","owner_name":"casey","created_at":"2022-11-30T18:25:15Z","updated_at":"2022-11-30T18:25:15Z"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabaseResponse(
            global::Neon.Database database)
        {
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseResponse" /> class.
        /// </summary>
        public DatabaseResponse()
        {
        }
    }
}