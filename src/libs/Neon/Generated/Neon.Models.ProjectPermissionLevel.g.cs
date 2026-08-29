
#nullable enable

namespace Neon
{
    /// <summary>
    /// The caller's effective permission for a project when<br/>
    /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
    /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
    /// Omitted for personal projects, flag-off organizations, and non-user<br/>
    /// subjects.
    /// </summary>
    public enum ProjectPermissionLevel
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        Viewer,
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
                ProjectPermissionLevel.Admin => "ADMIN",
                ProjectPermissionLevel.Editor => "EDITOR",
                ProjectPermissionLevel.Viewer => "VIEWER",
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
                "ADMIN" => ProjectPermissionLevel.Admin,
                "EDITOR" => ProjectPermissionLevel.Editor,
                "VIEWER" => ProjectPermissionLevel.Viewer,
                _ => null,
            };
        }
    }
}