
#nullable enable

namespace Neon
{
    /// <summary>
    /// Request to test the branch's saved email provider. Only the recipient is supplied; the stored<br/>
    /// SMTP settings and password are used server-side.
    /// </summary>
    public sealed partial class SendNeonAuthEmailProviderTestRequest
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
        /// Initializes a new instance of the <see cref="SendNeonAuthEmailProviderTestRequest" /> class.
        /// </summary>
        /// <param name="recipientEmail">
        /// The email address to send the test email to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendNeonAuthEmailProviderTestRequest(
            string recipientEmail)
        {
            this.RecipientEmail = recipientEmail ?? throw new global::System.ArgumentNullException(nameof(recipientEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthEmailProviderTestRequest" /> class.
        /// </summary>
        public SendNeonAuthEmailProviderTestRequest()
        {
        }

    }
}