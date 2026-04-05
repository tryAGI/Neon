#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JWKSCreationOperation : global::System.IEquatable<JWKSCreationOperation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.JWKSResponse? Response { get; init; }
#else
        public global::Neon.JWKSResponse? Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response))]
#endif
        public bool IsResponse => Response != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OperationsResponse? OperationsResponse { get; init; }
#else
        public global::Neon.OperationsResponse? OperationsResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OperationsResponse))]
#endif
        public bool IsOperationsResponse => OperationsResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JWKSCreationOperation(global::Neon.JWKSResponse value) => new JWKSCreationOperation((global::Neon.JWKSResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.JWKSResponse?(JWKSCreationOperation @this) => @this.Response;

        /// <summary>
        /// 
        /// </summary>
        public JWKSCreationOperation(global::Neon.JWKSResponse? value)
        {
            Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JWKSCreationOperation(global::Neon.OperationsResponse value) => new JWKSCreationOperation((global::Neon.OperationsResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OperationsResponse?(JWKSCreationOperation @this) => @this.OperationsResponse;

        /// <summary>
        /// 
        /// </summary>
        public JWKSCreationOperation(global::Neon.OperationsResponse? value)
        {
            OperationsResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JWKSCreationOperation(
            global::Neon.JWKSResponse? response,
            global::Neon.OperationsResponse? operationsResponse
            )
        {
            Response = response;
            OperationsResponse = operationsResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OperationsResponse as object ??
            Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Response?.ToString() ??
            OperationsResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse && IsOperationsResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.JWKSResponse?, TResult>? response = null,
            global::System.Func<global::Neon.OperationsResponse?, TResult>? operationsResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse && response != null)
            {
                return response(Response!);
            }
            else if (IsOperationsResponse && operationsResponse != null)
            {
                return operationsResponse(OperationsResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.JWKSResponse?>? response = null,
            global::System.Action<global::Neon.OperationsResponse?>? operationsResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
            else if (IsOperationsResponse)
            {
                operationsResponse?.Invoke(OperationsResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response,
                typeof(global::Neon.JWKSResponse),
                OperationsResponse,
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
        public bool Equals(JWKSCreationOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.JWKSResponse?>.Default.Equals(Response, other.Response) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OperationsResponse?>.Default.Equals(OperationsResponse, other.OperationsResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JWKSCreationOperation obj1, JWKSCreationOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JWKSCreationOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JWKSCreationOperation obj1, JWKSCreationOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JWKSCreationOperation o && Equals(o);
        }
    }
}
