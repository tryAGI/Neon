
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SendNeonAuthTestEmailRequest
    {
        /// <summary>
        /// Hostname of the email server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// TCP port of the SMTP server. Common values: 25 (SMTP), 465 (SMTPS), 587 (submission).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// Username for authenticating with the SMTP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Password for authenticating with the SMTP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Email address used as the From address on outgoing auth emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderEmail { get; set; }

        /// <summary>
        /// Display name shown as the sender in outgoing emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderName { get; set; }

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
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailRequest" /> class.
        /// </summary>
        /// <param name="host">
        /// Hostname of the email server.
        /// </param>
        /// <param name="port">
        /// TCP port of the SMTP server. Common values: 25 (SMTP), 465 (SMTPS), 587 (submission).
        /// </param>
        /// <param name="username">
        /// Username for authenticating with the SMTP server.
        /// </param>
        /// <param name="password">
        /// Password for authenticating with the SMTP server.
        /// </param>
        /// <param name="senderEmail">
        /// Email address used as the From address on outgoing auth emails.
        /// </param>
        /// <param name="senderName">
        /// Display name shown as the sender in outgoing emails.
        /// </param>
        /// <param name="recipientEmail">
        /// The email address to send the test email to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendNeonAuthTestEmailRequest(
            string host,
            int port,
            string username,
            string password,
            string senderEmail,
            string senderName,
            string recipientEmail)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Port = port;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.SenderEmail = senderEmail ?? throw new global::System.ArgumentNullException(nameof(senderEmail));
            this.SenderName = senderName ?? throw new global::System.ArgumentNullException(nameof(senderName));
            this.RecipientEmail = recipientEmail ?? throw new global::System.ArgumentNullException(nameof(recipientEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailRequest" /> class.
        /// </summary>
        public SendNeonAuthTestEmailRequest()
        {
        }

    }
}