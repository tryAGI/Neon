
#nullable enable

namespace Neon
{
    /// <summary>
    /// Organization-level role used by project member role management.
    /// </summary>
    public enum ProjectMemberOrgRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Collaborator,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMemberOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMemberOrgRole value)
        {
            return value switch
            {
                ProjectMemberOrgRole.Admin => "admin",
                ProjectMemberOrgRole.Collaborator => "collaborator",
                ProjectMemberOrgRole.Editor => "editor",
                ProjectMemberOrgRole.Member => "member",
                ProjectMemberOrgRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMemberOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectMemberOrgRole.Admin,
                "collaborator" => ProjectMemberOrgRole.Collaborator,
                "editor" => ProjectMemberOrgRole.Editor,
                "member" => ProjectMemberOrgRole.Member,
                "viewer" => ProjectMemberOrgRole.Viewer,
                _ => null,
            };
        }
    }
}