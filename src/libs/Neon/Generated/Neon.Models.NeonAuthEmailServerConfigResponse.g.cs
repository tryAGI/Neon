#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NeonAuthEmailServerConfigResponse : global::System.IEquatable<NeonAuthEmailServerConfigResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.StandardEmailServerResponse? Standard { get; init; }
#else
        public global::Neon.StandardEmailServerResponse? Standard { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Standard))]
#endif
        public bool IsStandard => Standard != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStandard(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.StandardEmailServerResponse? value)
        {
            value = Standard;
            return IsStandard;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.StandardEmailServerResponse PickStandard() => IsStandard
            ? Standard!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Standard' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.SharedEmailServer? Shared { get; init; }
#else
        public global::Neon.SharedEmailServer? Shared { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared))]
#endif
        public bool IsShared => Shared != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.SharedEmailServer? value)
        {
            value = Shared;
            return IsShared;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.SharedEmailServer PickShared() => IsShared
            ? Shared!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NeonAuthEmailServerConfigResponse(global::Neon.StandardEmailServerResponse value) => new NeonAuthEmailServerConfigResponse((global::Neon.StandardEmailServerResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.StandardEmailServerResponse?(NeonAuthEmailServerConfigResponse @this) => @this.Standard;

        /// <summary>
        ///
        /// </summary>
        public NeonAuthEmailServerConfigResponse(global::Neon.StandardEmailServerResponse? value)
        {
            Standard = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NeonAuthEmailServerConfigResponse FromStandard(global::Neon.StandardEmailServerResponse? value) => new NeonAuthEmailServerConfigResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NeonAuthEmailServerConfigResponse(global::Neon.SharedEmailServer value) => new NeonAuthEmailServerConfigResponse((global::Neon.SharedEmailServer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.SharedEmailServer?(NeonAuthEmailServerConfigResponse @this) => @this.Shared;

        /// <summary>
        ///
        /// </summary>
        public NeonAuthEmailServerConfigResponse(global::Neon.SharedEmailServer? value)
        {
            Shared = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NeonAuthEmailServerConfigResponse FromShared(global::Neon.SharedEmailServer? value) => new NeonAuthEmailServerConfigResponse(value);

        /// <summary>
        ///
        /// </summary>
        public NeonAuthEmailServerConfigResponse(
            global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType? type,
            global::Neon.StandardEmailServerResponse? standard,
            global::Neon.SharedEmailServer? shared
            )
        {
            Type = type;

            Standard = standard;
            Shared = shared;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared as object ??
            Standard as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Standard?.ToString() ??
            Shared?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStandard && !IsShared || !IsStandard && IsShared;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.StandardEmailServerResponse, TResult>? standard = null,
            global::System.Func<global::Neon.SharedEmailServer, TResult>? shared = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandard && standard != null)
            {
                return standard(Standard!);
            }
            else if (IsShared && shared != null)
            {
                return shared(Shared!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.StandardEmailServerResponse>? standard = null,

            global::System.Action<global::Neon.SharedEmailServer>? shared = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandard)
            {
                standard?.Invoke(Standard!);
            }
            else if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.StandardEmailServerResponse>? standard = null,
            global::System.Action<global::Neon.SharedEmailServer>? shared = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandard)
            {
                standard?.Invoke(Standard!);
            }
            else if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Standard,
                typeof(global::Neon.StandardEmailServerResponse),
                Shared,
                typeof(global::Neon.SharedEmailServer),
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
        public bool Equals(NeonAuthEmailServerConfigResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.StandardEmailServerResponse?>.Default.Equals(Standard, other.Standard) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.SharedEmailServer?>.Default.Equals(Shared, other.Shared)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NeonAuthEmailServerConfigResponse obj1, NeonAuthEmailServerConfigResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NeonAuthEmailServerConfigResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NeonAuthEmailServerConfigResponse obj1, NeonAuthEmailServerConfigResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NeonAuthEmailServerConfigResponse o && Equals(o);
        }
    }
}
