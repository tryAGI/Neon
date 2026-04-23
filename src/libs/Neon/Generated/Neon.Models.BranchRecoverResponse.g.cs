#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchRecoverResponse : global::System.IEquatable<BranchRecoverResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.BranchResponse? BranchResponse { get; init; }
#else
        public global::Neon.BranchResponse? BranchResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchResponse))]
#endif
        public bool IsBranchResponse => BranchResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.EndpointsOptionalResponse? EndpointsOptional { get; init; }
#else
        public global::Neon.EndpointsOptionalResponse? EndpointsOptional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndpointsOptional))]
#endif
        public bool IsEndpointsOptional => EndpointsOptional != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchRecoverResponse(global::Neon.BranchResponse value) => new BranchRecoverResponse((global::Neon.BranchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.BranchResponse?(BranchRecoverResponse @this) => @this.BranchResponse;

        /// <summary>
        /// 
        /// </summary>
        public BranchRecoverResponse(global::Neon.BranchResponse? value)
        {
            BranchResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchRecoverResponse(global::Neon.EndpointsOptionalResponse value) => new BranchRecoverResponse((global::Neon.EndpointsOptionalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.EndpointsOptionalResponse?(BranchRecoverResponse @this) => @this.EndpointsOptional;

        /// <summary>
        /// 
        /// </summary>
        public BranchRecoverResponse(global::Neon.EndpointsOptionalResponse? value)
        {
            EndpointsOptional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BranchRecoverResponse(
            global::Neon.BranchResponse? branchResponse,
            global::Neon.EndpointsOptionalResponse? endpointsOptional
            )
        {
            BranchResponse = branchResponse;
            EndpointsOptional = endpointsOptional;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EndpointsOptional as object ??
            BranchResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BranchResponse?.ToString() ??
            EndpointsOptional?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBranchResponse && IsEndpointsOptional;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.BranchResponse?, TResult>? branchResponse = null,
            global::System.Func<global::Neon.EndpointsOptionalResponse?, TResult>? endpointsOptional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBranchResponse && branchResponse != null)
            {
                return branchResponse(BranchResponse!);
            }
            else if (IsEndpointsOptional && endpointsOptional != null)
            {
                return endpointsOptional(EndpointsOptional!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.BranchResponse?>? branchResponse = null,
            global::System.Action<global::Neon.EndpointsOptionalResponse?>? endpointsOptional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBranchResponse)
            {
                branchResponse?.Invoke(BranchResponse!);
            }
            else if (IsEndpointsOptional)
            {
                endpointsOptional?.Invoke(EndpointsOptional!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BranchResponse,
                typeof(global::Neon.BranchResponse),
                EndpointsOptional,
                typeof(global::Neon.EndpointsOptionalResponse),
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
        public bool Equals(BranchRecoverResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.BranchResponse?>.Default.Equals(BranchResponse, other.BranchResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.EndpointsOptionalResponse?>.Default.Equals(EndpointsOptional, other.EndpointsOptional) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchRecoverResponse obj1, BranchRecoverResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchRecoverResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchRecoverResponse obj1, BranchRecoverResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchRecoverResponse o && Equals(o);
        }
    }
}
