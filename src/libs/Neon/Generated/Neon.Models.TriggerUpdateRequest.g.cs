#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Partial trigger update discriminated by `type`. The supported trigger<br/>
    /// types are `schedule` and `storage_object_created`.
    /// </summary>
    public readonly partial struct TriggerUpdateRequest : global::System.IEquatable<TriggerUpdateRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Neon.TriggerUpdateRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ScheduleTriggerUpdateRequest? Schedule { get; init; }
#else
        public global::Neon.ScheduleTriggerUpdateRequest? Schedule { get; }
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
            out global::Neon.ScheduleTriggerUpdateRequest? value)
        {
            value = Schedule;
            return IsSchedule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.ScheduleTriggerUpdateRequest PickSchedule() => IsSchedule
            ? Schedule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Schedule' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.StorageObjectCreatedTriggerUpdateRequest? StorageObjectCreated { get; init; }
#else
        public global::Neon.StorageObjectCreatedTriggerUpdateRequest? StorageObjectCreated { get; }
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
            out global::Neon.StorageObjectCreatedTriggerUpdateRequest? value)
        {
            value = StorageObjectCreated;
            return IsStorageObjectCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.StorageObjectCreatedTriggerUpdateRequest PickStorageObjectCreated() => IsStorageObjectCreated
            ? StorageObjectCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StorageObjectCreated' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TriggerUpdateRequest(global::Neon.ScheduleTriggerUpdateRequest value) => new TriggerUpdateRequest((global::Neon.ScheduleTriggerUpdateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.ScheduleTriggerUpdateRequest?(TriggerUpdateRequest @this) => @this.Schedule;

        /// <summary>
        ///
        /// </summary>
        public TriggerUpdateRequest(global::Neon.ScheduleTriggerUpdateRequest? value)
        {
            Schedule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TriggerUpdateRequest FromSchedule(global::Neon.ScheduleTriggerUpdateRequest? value) => new TriggerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TriggerUpdateRequest(global::Neon.StorageObjectCreatedTriggerUpdateRequest value) => new TriggerUpdateRequest((global::Neon.StorageObjectCreatedTriggerUpdateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.StorageObjectCreatedTriggerUpdateRequest?(TriggerUpdateRequest @this) => @this.StorageObjectCreated;

        /// <summary>
        ///
        /// </summary>
        public TriggerUpdateRequest(global::Neon.StorageObjectCreatedTriggerUpdateRequest? value)
        {
            StorageObjectCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TriggerUpdateRequest FromStorageObjectCreated(global::Neon.StorageObjectCreatedTriggerUpdateRequest? value) => new TriggerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public TriggerUpdateRequest(
            global::Neon.TriggerUpdateRequestDiscriminatorType? type,
            global::Neon.ScheduleTriggerUpdateRequest? schedule,
            global::Neon.StorageObjectCreatedTriggerUpdateRequest? storageObjectCreated
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
            global::System.Func<global::Neon.ScheduleTriggerUpdateRequest, TResult>? schedule = null,
            global::System.Func<global::Neon.StorageObjectCreatedTriggerUpdateRequest, TResult>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule && schedule != null)
            {
                return schedule(Schedule!);
            }
            else if (IsStorageObjectCreated && storageObjectCreated != null)
            {
                return storageObjectCreated(StorageObjectCreated!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ScheduleTriggerUpdateRequest>? schedule = null,

            global::System.Action<global::Neon.StorageObjectCreatedTriggerUpdateRequest>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
            else if (IsStorageObjectCreated)
            {
                storageObjectCreated?.Invoke(StorageObjectCreated!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.ScheduleTriggerUpdateRequest>? schedule = null,
            global::System.Action<global::Neon.StorageObjectCreatedTriggerUpdateRequest>? storageObjectCreated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
            else if (IsStorageObjectCreated)
            {
                storageObjectCreated?.Invoke(StorageObjectCreated!);
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
                typeof(global::Neon.ScheduleTriggerUpdateRequest),
                StorageObjectCreated,
                typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequest),
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
        public bool Equals(TriggerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ScheduleTriggerUpdateRequest?>.Default.Equals(Schedule, other.Schedule) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.StorageObjectCreatedTriggerUpdateRequest?>.Default.Equals(StorageObjectCreated, other.StorageObjectCreated)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TriggerUpdateRequest obj1, TriggerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TriggerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TriggerUpdateRequest obj1, TriggerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TriggerUpdateRequest o && Equals(o);
        }
    }
}
