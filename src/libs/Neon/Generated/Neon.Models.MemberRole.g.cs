
#nullable enable

namespace Neon
{
    /// <summary>
    /// Organization member's role. `admin`: full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
    /// </summary>
    public enum MemberRole
    {
        /// <summary>
        /// full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        Admin,
        /// <summary>
        /// full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        Collaborator,
        /// <summary>
        /// full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        Editor,
        /// <summary>
        /// full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        Member,
        /// <summary>
        /// full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemberRole value)
        {
            return value switch
            {
                MemberRole.Admin => "admin",
                MemberRole.Collaborator => "collaborator",
                MemberRole.Editor => "editor",
                MemberRole.Member => "member",
                MemberRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemberRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => MemberRole.Admin,
                "collaborator" => MemberRole.Collaborator,
                "editor" => MemberRole.Editor,
                "member" => MemberRole.Member,
                "viewer" => MemberRole.Viewer,
                _ => null,
            };
        }
    }
}