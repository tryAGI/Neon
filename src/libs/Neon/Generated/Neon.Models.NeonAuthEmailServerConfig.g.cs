#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NeonAuthEmailServerConfig : global::System.IEquatable<NeonAuthEmailServerConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Neon.NeonAuthEmailServerConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.StandardEmailServer? Standard { get; init; }
#else
        public global::Neon.StandardEmailServer? Standard { get; }
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
        public static implicit operator NeonAuthEmailServerConfig(global::Neon.StandardEmailServer value) => new NeonAuthEmailServerConfig((global::Neon.StandardEmailServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.StandardEmailServer?(NeonAuthEmailServerConfig @this) => @this.Standard;

        /// <summary>
        /// 
        /// </summary>
        public NeonAuthEmailServerConfig(global::Neon.StandardEmailServer? value)
        {
            Standard = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NeonAuthEmailServerConfig(global::Neon.SharedEmailServer value) => new NeonAuthEmailServerConfig((global::Neon.SharedEmailServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.SharedEmailServer?(NeonAuthEmailServerConfig @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public NeonAuthEmailServerConfig(global::Neon.SharedEmailServer? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NeonAuthEmailServerConfig(
            global::Neon.NeonAuthEmailServerConfigDiscriminatorType? type,
            global::Neon.StandardEmailServer? standard,
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
            global::System.Func<global::Neon.StandardEmailServer?, TResult>? standard = null,
            global::System.Func<global::Neon.SharedEmailServer?, TResult>? shared = null,
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
            global::System.Action<global::Neon.StandardEmailServer?>? standard = null,
            global::System.Action<global::Neon.SharedEmailServer?>? shared = null,
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
                typeof(global::Neon.StandardEmailServer),
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
        public bool Equals(NeonAuthEmailServerConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.StandardEmailServer?>.Default.Equals(Standard, other.Standard) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.SharedEmailServer?>.Default.Equals(Shared, other.Shared) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NeonAuthEmailServerConfig obj1, NeonAuthEmailServerConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NeonAuthEmailServerConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NeonAuthEmailServerConfig obj1, NeonAuthEmailServerConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NeonAuthEmailServerConfig o && Equals(o);
        }
    }
}
