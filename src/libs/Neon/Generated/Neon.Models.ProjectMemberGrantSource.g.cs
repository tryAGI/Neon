
#nullable enable

namespace Neon
{
    /// <summary>
    /// How a member's project access is granted.
    /// </summary>
    public enum ProjectMemberGrantSource
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        OrgAdminOverride,
        /// <summary>
        ///
        /// </summary>
        OrgRoleDefault,
        /// <summary>
        ///
        /// </summary>
        Unassigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMemberGrantSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMemberGrantSource value)
        {
            return value switch
            {
                ProjectMemberGrantSource.Explicit => "explicit",
                ProjectMemberGrantSource.OrgAdminOverride => "org_admin_override",
                ProjectMemberGrantSource.OrgRoleDefault => "org_role_default",
                ProjectMemberGrantSource.Unassigned => "unassigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMemberGrantSource? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => ProjectMemberGrantSource.Explicit,
                "org_admin_override" => ProjectMemberGrantSource.OrgAdminOverride,
                "org_role_default" => ProjectMemberGrantSource.OrgRoleDefault,
                "unassigned" => ProjectMemberGrantSource.Unassigned,
                _ => null,
            };
        }
    }
}