
#nullable enable

namespace Neon
{
    /// <summary>
    /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
    /// and `admin` maps to `ADMIN`.
    /// </summary>
    public enum ProjectRole
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
    public static class ProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRole value)
        {
            return value switch
            {
                ProjectRole.Admin => "admin",
                ProjectRole.Editor => "editor",
                ProjectRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectRole.Admin,
                "editor" => ProjectRole.Editor,
                "viewer" => ProjectRole.Viewer,
                _ => null,
            };
        }
    }
}