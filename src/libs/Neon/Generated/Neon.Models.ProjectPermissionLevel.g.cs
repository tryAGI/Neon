
#nullable enable

namespace Neon
{
    /// <summary>
    /// The caller's effective permission for a project when<br/>
    /// per-project permissions are enabled. Values correspond to viewer,<br/>
    /// editor, and admin/manage project access levels. Omitted for personal<br/>
    /// projects, flag-off organizations, and non-user subjects.
    /// </summary>
    public enum ProjectPermissionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        CanEdit,
        /// <summary>
        /// 
        /// </summary>
        CanManage,
        /// <summary>
        /// 
        /// </summary>
        CanView,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectPermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectPermissionLevel value)
        {
            return value switch
            {
                ProjectPermissionLevel.CanEdit => "CAN_EDIT",
                ProjectPermissionLevel.CanManage => "CAN_MANAGE",
                ProjectPermissionLevel.CanView => "CAN_VIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectPermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "CAN_EDIT" => ProjectPermissionLevel.CanEdit,
                "CAN_MANAGE" => ProjectPermissionLevel.CanManage,
                "CAN_VIEW" => ProjectPermissionLevel.CanView,
                _ => null,
            };
        }
    }
}