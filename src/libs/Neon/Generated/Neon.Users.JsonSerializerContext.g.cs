
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EmptyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCardBrand), TypeInfoPropertyName = "PaymentSourceBankCardBrand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccountState), TypeInfoPropertyName = "BillingAccountState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType), TypeInfoPropertyName = "BillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingPaymentMethod), TypeInfoPropertyName = "BillingPaymentMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserAuthAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.IdentityProviderId), TypeInfoPropertyName = "IdentityProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponseAuthMethod), TypeInfoPropertyName = "AuthDetailsResponseAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TransferProjectsToOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponseLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCardBrand?), TypeInfoPropertyName = "NullablePaymentSourceBankCardBrand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccountState?), TypeInfoPropertyName = "NullableBillingAccountState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType?), TypeInfoPropertyName = "NullableBillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingPaymentMethod?), TypeInfoPropertyName = "NullableBillingPaymentMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.IdentityProviderId?), TypeInfoPropertyName = "NullableIdentityProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponseAuthMethod?), TypeInfoPropertyName = "NullableAuthDetailsResponseAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CurrentUserAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectsWithIntegrationResponseProject>))]
    internal sealed partial class UsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand)

                    || typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand?)

                    || typeToConvert == typeof(global::Neon.BillingAccountState)

                    || typeToConvert == typeof(global::Neon.BillingAccountState?)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType?)

                    || typeToConvert == typeof(global::Neon.BillingPaymentMethod)

                    || typeToConvert == typeof(global::Neon.BillingPaymentMethod?)

                    || typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod)

                    || typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod?)

                    || typeToConvert == typeof(global::Neon.IdentityProviderId)

                    || typeToConvert == typeof(global::Neon.IdentityProviderId?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand))
                {
                    return new global::Neon.JsonConverters.PaymentSourceBankCardBrandJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand?))
                {
                    return new global::Neon.JsonConverters.PaymentSourceBankCardBrandNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingAccountState))
                {
                    return new global::Neon.JsonConverters.BillingAccountStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingAccountState?))
                {
                    return new global::Neon.JsonConverters.BillingAccountStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType?))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingPaymentMethod))
                {
                    return new global::Neon.JsonConverters.BillingPaymentMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingPaymentMethod?))
                {
                    return new global::Neon.JsonConverters.BillingPaymentMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod))
                {
                    return new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod?))
                {
                    return new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.IdentityProviderId))
                {
                    return new global::Neon.JsonConverters.IdentityProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.IdentityProviderId?))
                {
                    return new global::Neon.JsonConverters.IdentityProviderIdNullableJsonConverter();
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
                    0 => new UsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}