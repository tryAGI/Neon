
#nullable enable

namespace Neon
{
    /// <summary>
    /// Machine-readable reason why storage is unavailable:<br/>
    /// - `org_not_entitled`: the org's `PlatformBranchableStorage` feature flag is off.<br/>
    /// - `region_unavailable`: the project's region has no storage admin service wired.<br/>
    /// - `branch_directory_missing`: the branch is not registered in the storage service.<br/>
    /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
    ///   have access to it.
    /// </summary>
    public enum BranchStorageNotEnabledReason
    {
        /// <summary>
        /// the branch is not registered in the storage service.
        /// </summary>
        BranchDirectoryMissing,
        /// <summary>
        /// the project or branch does not exist, or the caller does not
        /// </summary>
        BranchNotFound,
        /// <summary>
        /// the org's `PlatformBranchableStorage` feature flag is off.
        /// </summary>
        OrgNotEntitled,
        /// <summary>
        /// the project's region has no storage admin service wired.
        /// </summary>
        RegionUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchStorageNotEnabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchStorageNotEnabledReason value)
        {
            return value switch
            {
                BranchStorageNotEnabledReason.BranchDirectoryMissing => "branch_directory_missing",
                BranchStorageNotEnabledReason.BranchNotFound => "branch_not_found",
                BranchStorageNotEnabledReason.OrgNotEntitled => "org_not_entitled",
                BranchStorageNotEnabledReason.RegionUnavailable => "region_unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchStorageNotEnabledReason? ToEnum(string value)
        {
            return value switch
            {
                "branch_directory_missing" => BranchStorageNotEnabledReason.BranchDirectoryMissing,
                "branch_not_found" => BranchStorageNotEnabledReason.BranchNotFound,
                "org_not_entitled" => BranchStorageNotEnabledReason.OrgNotEntitled,
                "region_unavailable" => BranchStorageNotEnabledReason.RegionUnavailable,
                _ => null,
            };
        }
    }
}