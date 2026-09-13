
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialScope), TypeInfoPropertyName = "CredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantedCredentialScope), TypeInfoPropertyName = "GrantedCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequestPrincipalType), TypeInfoPropertyName = "CreateCredentialRequestPrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.GrantedCredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponsePrincipalType), TypeInfoPropertyName = "RotateCredentialResponsePrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CredentialMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialScope?), TypeInfoPropertyName = "NullableCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantedCredentialScope?), TypeInfoPropertyName = "NullableGrantedCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequestPrincipalType?), TypeInfoPropertyName = "NullableCreateCredentialRequestPrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponsePrincipalType?), TypeInfoPropertyName = "NullableRotateCredentialResponsePrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.GrantedCredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CredentialMeta>))]
    internal sealed partial class CredentialsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CredentialsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CredentialsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CredentialsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Neon.CredentialScope)

                    || typeToConvert == typeof(global::Neon.CredentialScope?)

                    || typeToConvert == typeof(global::Neon.GrantedCredentialScope)

                    || typeToConvert == typeof(global::Neon.GrantedCredentialScope?)

                    || typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType)

                    || typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType?)

                    || typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType)

                    || typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Neon.CredentialScope))
                {
                    return new global::Neon.JsonConverters.CredentialScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CredentialScope?))
                {
                    return new global::Neon.JsonConverters.CredentialScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GrantedCredentialScope))
                {
                    return new global::Neon.JsonConverters.GrantedCredentialScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GrantedCredentialScope?))
                {
                    return new global::Neon.JsonConverters.GrantedCredentialScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType))
                {
                    return new global::Neon.JsonConverters.CreateCredentialRequestPrincipalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType?))
                {
                    return new global::Neon.JsonConverters.CreateCredentialRequestPrincipalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType))
                {
                    return new global::Neon.JsonConverters.RotateCredentialResponsePrincipalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType?))
                {
                    return new global::Neon.JsonConverters.RotateCredentialResponsePrincipalTypeNullableJsonConverter();
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
                    0 => new CredentialsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}