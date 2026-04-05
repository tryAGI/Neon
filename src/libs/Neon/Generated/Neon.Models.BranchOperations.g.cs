#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchOperations : global::System.IEquatable<BranchOperations>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.BranchResponse? Response1 { get; init; }
#else
        public global::Neon.BranchResponse? Response1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response1))]
#endif
        public bool IsResponse1 => Response1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OperationsResponse? Response2 { get; init; }
#else
        public global::Neon.OperationsResponse? Response2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response2))]
#endif
        public bool IsResponse2 => Response2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchOperations(global::Neon.BranchResponse value) => new BranchOperations((global::Neon.BranchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.BranchResponse?(BranchOperations @this) => @this.Response1;

        /// <summary>
        /// 
        /// </summary>
        public BranchOperations(global::Neon.BranchResponse? value)
        {
            Response1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchOperations(global::Neon.OperationsResponse value) => new BranchOperations((global::Neon.OperationsResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OperationsResponse?(BranchOperations @this) => @this.Response2;

        /// <summary>
        /// 
        /// </summary>
        public BranchOperations(global::Neon.OperationsResponse? value)
        {
            Response2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BranchOperations(
            global::Neon.BranchResponse? response1,
            global::Neon.OperationsResponse? response2
            )
        {
            Response1 = response1;
            Response2 = response2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Response2 as object ??
            Response1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Response1?.ToString() ??
            Response2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse1 && IsResponse2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.BranchResponse?, TResult>? response1 = null,
            global::System.Func<global::Neon.OperationsResponse?, TResult>? response2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse1 && response1 != null)
            {
                return response1(Response1!);
            }
            else if (IsResponse2 && response2 != null)
            {
                return response2(Response2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.BranchResponse?>? response1 = null,
            global::System.Action<global::Neon.OperationsResponse?>? response2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse1)
            {
                response1?.Invoke(Response1!);
            }
            else if (IsResponse2)
            {
                response2?.Invoke(Response2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response1,
                typeof(global::Neon.BranchResponse),
                Response2,
                typeof(global::Neon.OperationsResponse),
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
        public bool Equals(BranchOperations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.BranchResponse?>.Default.Equals(Response1, other.Response1) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OperationsResponse?>.Default.Equals(Response2, other.Response2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchOperations obj1, BranchOperations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchOperations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchOperations obj1, BranchOperations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchOperations o && Equals(o);
        }
    }
}
