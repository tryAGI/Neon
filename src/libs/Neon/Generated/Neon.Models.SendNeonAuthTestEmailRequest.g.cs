#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SendNeonAuthTestEmailRequest : global::System.IEquatable<SendNeonAuthTestEmailRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.StandardEmailServer? StandardServer { get; init; }
#else
        public global::Neon.StandardEmailServer? StandardServer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandardServer))]
#endif
        public bool IsStandardServer => StandardServer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.SendNeonAuthTestEmailRequestVariant2? SendNeonAuthTestEmailRequestVariant2 { get; init; }
#else
        public global::Neon.SendNeonAuthTestEmailRequestVariant2? SendNeonAuthTestEmailRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SendNeonAuthTestEmailRequestVariant2))]
#endif
        public bool IsSendNeonAuthTestEmailRequestVariant2 => SendNeonAuthTestEmailRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SendNeonAuthTestEmailRequest(global::Neon.StandardEmailServer value) => new SendNeonAuthTestEmailRequest((global::Neon.StandardEmailServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.StandardEmailServer?(SendNeonAuthTestEmailRequest @this) => @this.StandardServer;

        /// <summary>
        /// 
        /// </summary>
        public SendNeonAuthTestEmailRequest(global::Neon.StandardEmailServer? value)
        {
            StandardServer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SendNeonAuthTestEmailRequest(global::Neon.SendNeonAuthTestEmailRequestVariant2 value) => new SendNeonAuthTestEmailRequest((global::Neon.SendNeonAuthTestEmailRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.SendNeonAuthTestEmailRequestVariant2?(SendNeonAuthTestEmailRequest @this) => @this.SendNeonAuthTestEmailRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SendNeonAuthTestEmailRequest(global::Neon.SendNeonAuthTestEmailRequestVariant2? value)
        {
            SendNeonAuthTestEmailRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SendNeonAuthTestEmailRequest(
            global::Neon.StandardEmailServer? standardServer,
            global::Neon.SendNeonAuthTestEmailRequestVariant2? sendNeonAuthTestEmailRequestVariant2
            )
        {
            StandardServer = standardServer;
            SendNeonAuthTestEmailRequestVariant2 = sendNeonAuthTestEmailRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SendNeonAuthTestEmailRequestVariant2 as object ??
            StandardServer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StandardServer?.ToString() ??
            SendNeonAuthTestEmailRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStandardServer && IsSendNeonAuthTestEmailRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.StandardEmailServer?, TResult>? standardServer = null,
            global::System.Func<global::Neon.SendNeonAuthTestEmailRequestVariant2?, TResult>? sendNeonAuthTestEmailRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardServer && standardServer != null)
            {
                return standardServer(StandardServer!);
            }
            else if (IsSendNeonAuthTestEmailRequestVariant2 && sendNeonAuthTestEmailRequestVariant2 != null)
            {
                return sendNeonAuthTestEmailRequestVariant2(SendNeonAuthTestEmailRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.StandardEmailServer?>? standardServer = null,
            global::System.Action<global::Neon.SendNeonAuthTestEmailRequestVariant2?>? sendNeonAuthTestEmailRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardServer)
            {
                standardServer?.Invoke(StandardServer!);
            }
            else if (IsSendNeonAuthTestEmailRequestVariant2)
            {
                sendNeonAuthTestEmailRequestVariant2?.Invoke(SendNeonAuthTestEmailRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StandardServer,
                typeof(global::Neon.StandardEmailServer),
                SendNeonAuthTestEmailRequestVariant2,
                typeof(global::Neon.SendNeonAuthTestEmailRequestVariant2),
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
        public bool Equals(SendNeonAuthTestEmailRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.StandardEmailServer?>.Default.Equals(StandardServer, other.StandardServer) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.SendNeonAuthTestEmailRequestVariant2?>.Default.Equals(SendNeonAuthTestEmailRequestVariant2, other.SendNeonAuthTestEmailRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SendNeonAuthTestEmailRequest obj1, SendNeonAuthTestEmailRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SendNeonAuthTestEmailRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SendNeonAuthTestEmailRequest obj1, SendNeonAuthTestEmailRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SendNeonAuthTestEmailRequest o && Equals(o);
        }
    }
}
