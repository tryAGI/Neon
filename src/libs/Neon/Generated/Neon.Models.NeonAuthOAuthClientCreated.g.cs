#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NeonAuthOAuthClientCreated : global::System.IEquatable<NeonAuthOAuthClientCreated>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.NeonAuthOAuthClient? NeonAuthOAuthClient { get; init; }
#else
        public global::Neon.NeonAuthOAuthClient? NeonAuthOAuthClient { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NeonAuthOAuthClient))]
#endif
        public bool IsNeonAuthOAuthClient => NeonAuthOAuthClient != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNeonAuthOAuthClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.NeonAuthOAuthClient? value)
        {
            value = NeonAuthOAuthClient;
            return IsNeonAuthOAuthClient;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.NeonAuthOAuthClient PickNeonAuthOAuthClient() => NeonAuthOAuthClient is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NeonAuthOAuthClient' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.NeonAuthOAuthClientCreatedVariant2? NeonAuthOAuthClientCreatedVariant2 { get; init; }
#else
        public global::Neon.NeonAuthOAuthClientCreatedVariant2? NeonAuthOAuthClientCreatedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NeonAuthOAuthClientCreatedVariant2))]
#endif
        public bool IsNeonAuthOAuthClientCreatedVariant2 => NeonAuthOAuthClientCreatedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNeonAuthOAuthClientCreatedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.NeonAuthOAuthClientCreatedVariant2? value)
        {
            value = NeonAuthOAuthClientCreatedVariant2;
            return IsNeonAuthOAuthClientCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.NeonAuthOAuthClientCreatedVariant2 PickNeonAuthOAuthClientCreatedVariant2() => NeonAuthOAuthClientCreatedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NeonAuthOAuthClientCreatedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NeonAuthOAuthClientCreated(global::Neon.NeonAuthOAuthClient value) => new NeonAuthOAuthClientCreated((global::Neon.NeonAuthOAuthClient?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.NeonAuthOAuthClient?(NeonAuthOAuthClientCreated @this) => @this.NeonAuthOAuthClient;

        /// <summary>
        ///
        /// </summary>
        public NeonAuthOAuthClientCreated(global::Neon.NeonAuthOAuthClient? value)
        {
            NeonAuthOAuthClient = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NeonAuthOAuthClientCreated FromNeonAuthOAuthClient(global::Neon.NeonAuthOAuthClient? value) => new NeonAuthOAuthClientCreated(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NeonAuthOAuthClientCreated(global::Neon.NeonAuthOAuthClientCreatedVariant2 value) => new NeonAuthOAuthClientCreated((global::Neon.NeonAuthOAuthClientCreatedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.NeonAuthOAuthClientCreatedVariant2?(NeonAuthOAuthClientCreated @this) => @this.NeonAuthOAuthClientCreatedVariant2;

        /// <summary>
        ///
        /// </summary>
        public NeonAuthOAuthClientCreated(global::Neon.NeonAuthOAuthClientCreatedVariant2? value)
        {
            NeonAuthOAuthClientCreatedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NeonAuthOAuthClientCreated FromNeonAuthOAuthClientCreatedVariant2(global::Neon.NeonAuthOAuthClientCreatedVariant2? value) => new NeonAuthOAuthClientCreated(value);

        /// <summary>
        ///
        /// </summary>
        public NeonAuthOAuthClientCreated(
            global::Neon.NeonAuthOAuthClient? neonAuthOAuthClient,
            global::Neon.NeonAuthOAuthClientCreatedVariant2? neonAuthOAuthClientCreatedVariant2
            )
        {
            NeonAuthOAuthClient = neonAuthOAuthClient;
            NeonAuthOAuthClientCreatedVariant2 = neonAuthOAuthClientCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NeonAuthOAuthClientCreatedVariant2 as object ??
            NeonAuthOAuthClient as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NeonAuthOAuthClient?.ToString() ??
            NeonAuthOAuthClientCreatedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNeonAuthOAuthClient && IsNeonAuthOAuthClientCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.NeonAuthOAuthClient, TResult>? neonAuthOAuthClient = null,
            global::System.Func<global::Neon.NeonAuthOAuthClientCreatedVariant2, TResult>? neonAuthOAuthClientCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NeonAuthOAuthClient is { } __value0 && neonAuthOAuthClient != null)
            {
                return neonAuthOAuthClient(__value0);
            }
            else if (NeonAuthOAuthClientCreatedVariant2 is { } __value1 && neonAuthOAuthClientCreatedVariant2 != null)
            {
                return neonAuthOAuthClientCreatedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.NeonAuthOAuthClient>? neonAuthOAuthClient = null,

            global::System.Action<global::Neon.NeonAuthOAuthClientCreatedVariant2>? neonAuthOAuthClientCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NeonAuthOAuthClient is { } __value0)
            {
                neonAuthOAuthClient?.Invoke(__value0);
            }
            else if (NeonAuthOAuthClientCreatedVariant2 is { } __value1)
            {
                neonAuthOAuthClientCreatedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.NeonAuthOAuthClient>? neonAuthOAuthClient = null,
            global::System.Action<global::Neon.NeonAuthOAuthClientCreatedVariant2>? neonAuthOAuthClientCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NeonAuthOAuthClient is { } __value0)
            {
                neonAuthOAuthClient?.Invoke(__value0);
            }
            else if (NeonAuthOAuthClientCreatedVariant2 is { } __value1)
            {
                neonAuthOAuthClientCreatedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NeonAuthOAuthClient,
                typeof(global::Neon.NeonAuthOAuthClient),
                NeonAuthOAuthClientCreatedVariant2,
                typeof(global::Neon.NeonAuthOAuthClientCreatedVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(NeonAuthOAuthClientCreated other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.NeonAuthOAuthClient?>.Default.Equals(NeonAuthOAuthClient, other.NeonAuthOAuthClient) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.NeonAuthOAuthClientCreatedVariant2?>.Default.Equals(NeonAuthOAuthClientCreatedVariant2, other.NeonAuthOAuthClientCreatedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NeonAuthOAuthClientCreated obj1, NeonAuthOAuthClientCreated obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NeonAuthOAuthClientCreated>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NeonAuthOAuthClientCreated obj1, NeonAuthOAuthClientCreated obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NeonAuthOAuthClientCreated o && Equals(o);
        }
    }
}
