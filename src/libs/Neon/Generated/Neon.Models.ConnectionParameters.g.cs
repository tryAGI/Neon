
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectionParameters
    {
        /// <summary>
        /// Database name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Database { get; set; }

        /// <summary>
        /// Password for the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Pooler hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PoolerHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionParameters" /> class.
        /// </summary>
        /// <param name="database">
        /// Database name
        /// </param>
        /// <param name="password">
        /// Password for the role
        /// </param>
        /// <param name="role">
        /// Role name
        /// </param>
        /// <param name="host">
        /// Hostname
        /// </param>
        /// <param name="poolerHost">
        /// Pooler hostname
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionParameters(
            string database,
            string password,
            string role,
            string host,
            string poolerHost)
        {
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.PoolerHost = poolerHost ?? throw new global::System.ArgumentNullException(nameof(poolerHost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionParameters" /> class.
        /// </summary>
        public ConnectionParameters()
        {
        }
    }
}