
#nullable enable

namespace Neon
{
    /// <summary>
    /// The role of the organization member. Some role values may not be<br/>
    /// available for all organizations.
    /// </summary>
    public enum MemberRole
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