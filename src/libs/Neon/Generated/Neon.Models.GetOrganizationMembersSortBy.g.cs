
#nullable enable

namespace Neon
{
    /// <summary>
    /// Default Value: joined_at
    /// </summary>
    public enum GetOrganizationMembersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        JoinedAt,
        /// <summary>
        /// 
        /// </summary>
        Role,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationMembersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationMembersSortBy value)
        {
            return value switch
            {
                GetOrganizationMembersSortBy.Email => "email",
                GetOrganizationMembersSortBy.JoinedAt => "joined_at",
                GetOrganizationMembersSortBy.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationMembersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "email" => GetOrganizationMembersSortBy.Email,
                "joined_at" => GetOrganizationMembersSortBy.JoinedAt,
                "role" => GetOrganizationMembersSortBy.Role,
                _ => null,
            };
        }
    }
}