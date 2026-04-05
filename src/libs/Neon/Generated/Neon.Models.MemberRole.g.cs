
#nullable enable

namespace Neon
{
    /// <summary>
    /// The role of the organization member
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
        Member,
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
                MemberRole.Member => "member",
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
                "member" => MemberRole.Member,
                _ => null,
            };
        }
    }
}