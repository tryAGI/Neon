
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SharedEmailServer
    {
        /// <summary>
        /// Email address used as the sender for outgoing messages from this shared email server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_email")]
        public string? SenderEmail { get; set; }

        /// <summary>
        /// Display name shown as the sender in outgoing emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedEmailServer" /> class.
        /// </summary>
        /// <param name="senderEmail">
        /// Email address used as the sender for outgoing messages from this shared email server.
        /// </param>
        /// <param name="senderName">
        /// Display name shown as the sender in outgoing emails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedEmailServer(
            string? senderEmail,
            string? senderName)
        {
            this.SenderEmail = senderEmail;
            this.SenderName = senderName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedEmailServer" /> class.
        /// </summary>
        public SharedEmailServer()
        {
        }

    }
}