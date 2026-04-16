
#nullable enable

namespace Neon
{
    /// <summary>
    /// The action performed by the operation
    /// </summary>
    public enum OperationAction
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyConfig,
        /// <summary>
        /// 
        /// </summary>
        ApplySchemaFromBranch,
        /// <summary>
        /// 
        /// </summary>
        ApplyStorageConfig,
        /// <summary>
        /// 
        /// </summary>
        CheckAvailability,
        /// <summary>
        /// 
        /// </summary>
        CreateBranch,
        /// <summary>
        /// 
        /// </summary>
        CreateCompute,
        /// <summary>
        /// 
        /// </summary>
        CreateTimeline,
        /// <summary>
        /// 
        /// </summary>
        DeleteTimeline,
        /// <summary>
        /// 
        /// </summary>
        DetachParentBranch,
        /// <summary>
        /// 
        /// </summary>
        DisableMaintenance,
        /// <summary>
        /// 
        /// </summary>
        ImportData,
        /// <summary>
        /// 
        /// </summary>
        PrepareSecondaryPageserver,
        /// <summary>
        /// 
        /// </summary>
        PrewarmReplica,
        /// <summary>
        /// 
        /// </summary>
        PromoteReplica,
        /// <summary>
        /// 
        /// </summary>
        ReplaceSafekeeper,
        /// <summary>
        /// 
        /// </summary>
        SetStorageNonDirty,
        /// <summary>
        /// 
        /// </summary>
        StartCompute,
        /// <summary>
        /// 
        /// </summary>
        StartReservedCompute,
        /// <summary>
        /// 
        /// </summary>
        SuspendCompute,
        /// <summary>
        /// 
        /// </summary>
        SwapBindingId,
        /// <summary>
        /// 
        /// </summary>
        SwitchPageserver,
        /// <summary>
        /// 
        /// </summary>
        SyncDbsAndRolesFromCompute,
        /// <summary>
        /// 
        /// </summary>
        TenantAttach,
        /// <summary>
        /// 
        /// </summary>
        TenantDetach,
        /// <summary>
        /// 
        /// </summary>
        TenantIgnore,
        /// <summary>
        /// 
        /// </summary>
        TenantReattach,
        /// <summary>
        /// 
        /// </summary>
        TimelineArchive,
        /// <summary>
        /// 
        /// </summary>
        TimelineMarkInvisible,
        /// <summary>
        /// 
        /// </summary>
        TimelineUnarchive,
        /// <summary>
        /// 
        /// </summary>
        TimelineUpdateProtectedConfig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperationAction value)
        {
            return value switch
            {
                OperationAction.ApplyConfig => "apply_config",
                OperationAction.ApplySchemaFromBranch => "apply_schema_from_branch",
                OperationAction.ApplyStorageConfig => "apply_storage_config",
                OperationAction.CheckAvailability => "check_availability",
                OperationAction.CreateBranch => "create_branch",
                OperationAction.CreateCompute => "create_compute",
                OperationAction.CreateTimeline => "create_timeline",
                OperationAction.DeleteTimeline => "delete_timeline",
                OperationAction.DetachParentBranch => "detach_parent_branch",
                OperationAction.DisableMaintenance => "disable_maintenance",
                OperationAction.ImportData => "import_data",
                OperationAction.PrepareSecondaryPageserver => "prepare_secondary_pageserver",
                OperationAction.PrewarmReplica => "prewarm_replica",
                OperationAction.PromoteReplica => "promote_replica",
                OperationAction.ReplaceSafekeeper => "replace_safekeeper",
                OperationAction.SetStorageNonDirty => "set_storage_non_dirty",
                OperationAction.StartCompute => "start_compute",
                OperationAction.StartReservedCompute => "start_reserved_compute",
                OperationAction.SuspendCompute => "suspend_compute",
                OperationAction.SwapBindingId => "swap_binding_id",
                OperationAction.SwitchPageserver => "switch_pageserver",
                OperationAction.SyncDbsAndRolesFromCompute => "sync_dbs_and_roles_from_compute",
                OperationAction.TenantAttach => "tenant_attach",
                OperationAction.TenantDetach => "tenant_detach",
                OperationAction.TenantIgnore => "tenant_ignore",
                OperationAction.TenantReattach => "tenant_reattach",
                OperationAction.TimelineArchive => "timeline_archive",
                OperationAction.TimelineMarkInvisible => "timeline_mark_invisible",
                OperationAction.TimelineUnarchive => "timeline_unarchive",
                OperationAction.TimelineUpdateProtectedConfig => "timeline_update_protected_config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperationAction? ToEnum(string value)
        {
            return value switch
            {
                "apply_config" => OperationAction.ApplyConfig,
                "apply_schema_from_branch" => OperationAction.ApplySchemaFromBranch,
                "apply_storage_config" => OperationAction.ApplyStorageConfig,
                "check_availability" => OperationAction.CheckAvailability,
                "create_branch" => OperationAction.CreateBranch,
                "create_compute" => OperationAction.CreateCompute,
                "create_timeline" => OperationAction.CreateTimeline,
                "delete_timeline" => OperationAction.DeleteTimeline,
                "detach_parent_branch" => OperationAction.DetachParentBranch,
                "disable_maintenance" => OperationAction.DisableMaintenance,
                "import_data" => OperationAction.ImportData,
                "prepare_secondary_pageserver" => OperationAction.PrepareSecondaryPageserver,
                "prewarm_replica" => OperationAction.PrewarmReplica,
                "promote_replica" => OperationAction.PromoteReplica,
                "replace_safekeeper" => OperationAction.ReplaceSafekeeper,
                "set_storage_non_dirty" => OperationAction.SetStorageNonDirty,
                "start_compute" => OperationAction.StartCompute,
                "start_reserved_compute" => OperationAction.StartReservedCompute,
                "suspend_compute" => OperationAction.SuspendCompute,
                "swap_binding_id" => OperationAction.SwapBindingId,
                "switch_pageserver" => OperationAction.SwitchPageserver,
                "sync_dbs_and_roles_from_compute" => OperationAction.SyncDbsAndRolesFromCompute,
                "tenant_attach" => OperationAction.TenantAttach,
                "tenant_detach" => OperationAction.TenantDetach,
                "tenant_ignore" => OperationAction.TenantIgnore,
                "tenant_reattach" => OperationAction.TenantReattach,
                "timeline_archive" => OperationAction.TimelineArchive,
                "timeline_mark_invisible" => OperationAction.TimelineMarkInvisible,
                "timeline_unarchive" => OperationAction.TimelineUnarchive,
                "timeline_update_protected_config" => OperationAction.TimelineUpdateProtectedConfig,
                _ => null,
            };
        }
    }
}