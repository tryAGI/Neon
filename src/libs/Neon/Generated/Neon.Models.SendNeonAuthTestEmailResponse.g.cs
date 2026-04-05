
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendNeonAuthTestEmailResponse
    {
        /// <summary>
        /// Whether the test email was sent successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The error message from the email server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the test email was sent successfully.
        /// </param>
        /// <param name="errorMessage">
        /// The error message from the email server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendNeonAuthTestEmailResponse(
            bool success,
            string? errorMessage)
        {
            this.Success = success;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendNeonAuthTestEmailResponse" /> class.
        /// </summary>
        public SendNeonAuthTestEmailResponse()
        {
        }
    }
}