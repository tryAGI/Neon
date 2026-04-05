
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendNeonAuthTestEmailRequestVariant2
    {
        /// <summary>
        /// The email address to send the test email to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailRequestVariant2" /> class.
        /// </summary>
        /// <param name="recipientEmail">
        /// The email address to send the test email to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendNeonAuthTestEmailRequestVariant2(
            string recipientEmail)
        {
            this.RecipientEmail = recipientEmail ?? throw new global::System.ArgumentNullException(nameof(recipientEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailRequestVariant2" /> class.
        /// </summary>
        public SendNeonAuthTestEmailRequestVariant2()
        {
        }
    }
}