
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthSupportedAuthProvider), TypeInfoPropertyName = "NeonAuthSupportedAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectOwnedBy), TypeInfoPropertyName = "NeonAuthProviderProjectOwnedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectTransferStatus), TypeInfoPropertyName = "NeonAuthProviderProjectTransferStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthRedirectURIWhitelistDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthRedirectURIWhitelistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthRedirectURIWhitelistDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAddDomainToRedirectURIWhitelistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EnableNeonAuthIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateBranchNeonAuthNewUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateNewUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthUserRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthUserRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAllowLocalhostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthAllowLocalhostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole), TypeInfoPropertyName = "NeonAuthOrganizationConfigCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole), TypeInfoPropertyName = "NeonAuthOrganizationConfigUpdateCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthMagicLinkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthMagicLinkConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPhoneNumberConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPhoneNumberConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListNeonAuthOauthProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPluginConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponse), TypeInfoPropertyName = "NeonAuthEmailServerConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailAndPasswordConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent), TypeInfoPropertyName = "NeonAuthWebhookConfigEnabledEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderId), TypeInfoPropertyName = "NeonAuthOauthProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderType), TypeInfoPropertyName = "NeonAuthOauthProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAddOAuthProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthUpdateOAuthProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SharedEmailServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StandardEmailServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StandardEmailServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfig), TypeInfoPropertyName = "NeonAuthEmailServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType), TypeInfoPropertyName = "NeonAuthEmailServerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType), TypeInfoPropertyName = "NeonAuthEmailServerConfigResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthEmailProviderTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailVerificationMethod), TypeInfoPropertyName = "NeonAuthEmailVerificationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailAndPasswordConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DisableNeonAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthSupportedAuthProvider?), TypeInfoPropertyName = "NullableNeonAuthSupportedAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectOwnedBy?), TypeInfoPropertyName = "NullableNeonAuthProviderProjectOwnedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectTransferStatus?), TypeInfoPropertyName = "NullableNeonAuthProviderProjectTransferStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?), TypeInfoPropertyName = "NullableNeonAuthOrganizationConfigCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?), TypeInfoPropertyName = "NullableNeonAuthOrganizationConfigUpdateCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponse?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?), TypeInfoPropertyName = "NullableNeonAuthWebhookConfigEnabledEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderId?), TypeInfoPropertyName = "NullableNeonAuthOauthProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderType?), TypeInfoPropertyName = "NullableNeonAuthOauthProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfig?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailVerificationMethod?), TypeInfoPropertyName = "NullableNeonAuthEmailVerificationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthRedirectURIWhitelistDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthOauthProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthWebhookConfigEnabledEvent>))]
    internal sealed partial class AuthSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuthSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuthSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Neon.JsonConverters.NeonAuthEmailServerConfigJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider)

                    || typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider?)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy?)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?)

                    || typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent)

                    || typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider))
                {
                    return new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider?))
                {
                    return new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy?))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus?))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent))
                {
                    return new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?))
                {
                    return new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AuthSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}