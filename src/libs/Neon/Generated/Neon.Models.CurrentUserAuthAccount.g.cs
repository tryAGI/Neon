
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CurrentUserAuthAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// DEPRECATED. Use `email` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Identity provider id from keycloak
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.IdentityProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.IdentityProviderId Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserAuthAccount" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="image"></param>
        /// <param name="login">
        /// DEPRECATED. Use `email` field.
        /// </param>
        /// <param name="name"></param>
        /// <param name="provider">
        /// Identity provider id from keycloak
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentUserAuthAccount(
            string email,
            string image,
            string login,
            string name,
            global::Neon.IdentityProviderId provider)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserAuthAccount" /> class.
        /// </summary>
        public CurrentUserAuthAccount()
        {
        }
    }
}