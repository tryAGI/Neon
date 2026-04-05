
#nullable enable

namespace Neon
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetOrganizationMembersSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationMembersSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationMembersSortOrder value)
        {
            return value switch
            {
                GetOrganizationMembersSortOrder.Asc => "asc",
                GetOrganizationMembersSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationMembersSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetOrganizationMembersSortOrder.Asc,
                "desc" => GetOrganizationMembersSortOrder.Desc,
                _ => null,
            };
        }
    }
}