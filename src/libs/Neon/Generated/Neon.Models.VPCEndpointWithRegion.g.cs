#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VPCEndpointWithRegion : global::System.IEquatable<VPCEndpointWithRegion>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.VPCEndpoint? VPCEndpoint { get; init; }
#else
        public global::Neon.VPCEndpoint? VPCEndpoint { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VPCEndpoint))]
#endif
        public bool IsVPCEndpoint => VPCEndpoint != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.VPCEndpointWithRegionVariant2? VPCEndpointWithRegionVariant2 { get; init; }
#else
        public global::Neon.VPCEndpointWithRegionVariant2? VPCEndpointWithRegionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VPCEndpointWithRegionVariant2))]
#endif
        public bool IsVPCEndpointWithRegionVariant2 => VPCEndpointWithRegionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VPCEndpointWithRegion(global::Neon.VPCEndpoint value) => new VPCEndpointWithRegion((global::Neon.VPCEndpoint?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.VPCEndpoint?(VPCEndpointWithRegion @this) => @this.VPCEndpoint;

        /// <summary>
        /// 
        /// </summary>
        public VPCEndpointWithRegion(global::Neon.VPCEndpoint? value)
        {
            VPCEndpoint = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VPCEndpointWithRegion(global::Neon.VPCEndpointWithRegionVariant2 value) => new VPCEndpointWithRegion((global::Neon.VPCEndpointWithRegionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.VPCEndpointWithRegionVariant2?(VPCEndpointWithRegion @this) => @this.VPCEndpointWithRegionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VPCEndpointWithRegion(global::Neon.VPCEndpointWithRegionVariant2? value)
        {
            VPCEndpointWithRegionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VPCEndpointWithRegion(
            global::Neon.VPCEndpoint? vPCEndpoint,
            global::Neon.VPCEndpointWithRegionVariant2? vPCEndpointWithRegionVariant2
            )
        {
            VPCEndpoint = vPCEndpoint;
            VPCEndpointWithRegionVariant2 = vPCEndpointWithRegionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VPCEndpointWithRegionVariant2 as object ??
            VPCEndpoint as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VPCEndpoint?.ToString() ??
            VPCEndpointWithRegionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVPCEndpoint && IsVPCEndpointWithRegionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.VPCEndpoint?, TResult>? vPCEndpoint = null,
            global::System.Func<global::Neon.VPCEndpointWithRegionVariant2?, TResult>? vPCEndpointWithRegionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVPCEndpoint && vPCEndpoint != null)
            {
                return vPCEndpoint(VPCEndpoint!);
            }
            else if (IsVPCEndpointWithRegionVariant2 && vPCEndpointWithRegionVariant2 != null)
            {
                return vPCEndpointWithRegionVariant2(VPCEndpointWithRegionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.VPCEndpoint?>? vPCEndpoint = null,
            global::System.Action<global::Neon.VPCEndpointWithRegionVariant2?>? vPCEndpointWithRegionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVPCEndpoint)
            {
                vPCEndpoint?.Invoke(VPCEndpoint!);
            }
            else if (IsVPCEndpointWithRegionVariant2)
            {
                vPCEndpointWithRegionVariant2?.Invoke(VPCEndpointWithRegionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VPCEndpoint,
                typeof(global::Neon.VPCEndpoint),
                VPCEndpointWithRegionVariant2,
                typeof(global::Neon.VPCEndpointWithRegionVariant2),
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
        public bool Equals(VPCEndpointWithRegion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.VPCEndpoint?>.Default.Equals(VPCEndpoint, other.VPCEndpoint) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.VPCEndpointWithRegionVariant2?>.Default.Equals(VPCEndpointWithRegionVariant2, other.VPCEndpointWithRegionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VPCEndpointWithRegion obj1, VPCEndpointWithRegion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VPCEndpointWithRegion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VPCEndpointWithRegion obj1, VPCEndpointWithRegion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VPCEndpointWithRegion o && Equals(o);
        }
    }
}
