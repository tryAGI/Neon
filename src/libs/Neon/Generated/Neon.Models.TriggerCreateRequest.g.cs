#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger creation payload discriminated by `type`. The supported trigger<br/>
    /// types are `schedule` and `storage_object_created`.
    /// </summary>
    public readonly partial struct TriggerCreateRequest : global::System.IEquatable<TriggerCreateRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Neon.TriggerCreateRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ScheduleTriggerCreateRequest? Schedule { get; init; }
#else
        public global::Neon.ScheduleTriggerCreateRequest? Schedule { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Schedule))]
#endif
        public bool IsSchedule => Schedule != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSchedule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.ScheduleTriggerCreateRequest? value)
        {
            value = Schedule;
            return IsSchedule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.ScheduleTriggerCreateRequest PickSchedule() => Schedule is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Schedule' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.StorageObjectCreatedTriggerCreateRequest? StorageObjectCreated { get; init; }
#else
        public global::Neon.StorageObjectCreatedTriggerCreateRequest? StorageObjectCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StorageObjectCreated))]
#endif
        public bool IsStorageObjectCreated => StorageObjectCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStorageObjectCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.StorageObjectCreatedTriggerCreateRequest? value)
        {
            value = StorageObjectCreated;
            return IsStorageObjectCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.StorageObjectCreatedTriggerCreateRequest PickStorageObjectCreated() => StorageObjectCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StorageObjectCreated' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TriggerCreateRequest(global::Neon.ScheduleTriggerCreateRequest value) => new TriggerCreateRequest((global::Neon.ScheduleTriggerCreateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.ScheduleTriggerCreateRequest?(TriggerCreateRequest @this) => @this.Schedule;

        /// <summary>
        ///
        /// </summary>
        public TriggerCreateRequest(global::Neon.ScheduleTriggerCreateRequest? value)
        {
            Schedule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TriggerCreateRequest FromSchedule(global::Neon.ScheduleTriggerCreateRequest? value) => new TriggerCreateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TriggerCreateRequest(global::Neon.StorageObjectCreatedTriggerCreateRequest value) => new TriggerCreateRequest((global::Neon.StorageObjectCreatedTriggerCreateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.StorageObjectCreatedTriggerCreateRequest?(TriggerCreateRequest @this) => @this.StorageObjectCreated;

        /// <summary>
        ///
        /// </summary>
        public TriggerCreateRequest(global::Neon.StorageObjectCreatedTriggerCreateRequest? value)
        {
            StorageObjectCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TriggerCreateRequest FromStorageObjectCreated(global::Neon.StorageObjectCreatedTriggerCreateRequest? value) => new TriggerCreateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public TriggerCreateRequest(
            global::Neon.TriggerCreateRequestDiscriminatorType? type,
            global::Neon.ScheduleTriggerCreateRequest? schedule,
            global::Neon.StorageObjectCreatedTriggerCreateRequest? storageObjectCreated
            )
        {
            Type = type;

            Schedule = schedule;
            StorageObjectCreated = storageObjectCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StorageObjectCreated as object ??
            Schedule as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Schedule?.ToString() ??
            StorageObjectCreated?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSchedule && !IsStorageObjectCreated || !IsSchedule && IsStorageObjectCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ScheduleTriggerCreateRequest, TResult>? schedule = null,
            global::System.Func<global::Neon.StorageObjectCreatedTriggerCreateRequest, TResult>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Schedule is { } __value0 && schedule != null)
            {
                return schedule(__value0);
            }
            else if (StorageObjectCreated is { } __value1 && storageObjectCreated != null)
            {
                return storageObjectCreated(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ScheduleTriggerCreateRequest>? schedule = null,

            global::System.Action<global::Neon.StorageObjectCreatedTriggerCreateRequest>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Schedule is { } __value0)
            {
                schedule?.Invoke(__value0);
            }
            else if (StorageObjectCreated is { } __value1)
            {
                storageObjectCreated?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.ScheduleTriggerCreateRequest>? schedule = null,
            global::System.Action<global::Neon.StorageObjectCreatedTriggerCreateRequest>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Schedule is { } __value0)
            {
                schedule?.Invoke(__value0);
            }
            else if (StorageObjectCreated is { } __value1)
            {
                storageObjectCreated?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Schedule,
                typeof(global::Neon.ScheduleTriggerCreateRequest),
                StorageObjectCreated,
                typeof(global::Neon.StorageObjectCreatedTriggerCreateRequest),
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
        public bool Equals(TriggerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ScheduleTriggerCreateRequest?>.Default.Equals(Schedule, other.Schedule) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.StorageObjectCreatedTriggerCreateRequest?>.Default.Equals(StorageObjectCreated, other.StorageObjectCreated)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TriggerCreateRequest obj1, TriggerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TriggerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TriggerCreateRequest obj1, TriggerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TriggerCreateRequest o && Equals(o);
        }
    }
}
