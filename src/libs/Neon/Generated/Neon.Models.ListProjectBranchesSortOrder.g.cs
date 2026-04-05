
#nullable enable

namespace Neon
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListProjectBranchesSortOrder
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
    public static class ListProjectBranchesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectBranchesSortOrder value)
        {
            return value switch
            {
                ListProjectBranchesSortOrder.Asc => "asc",
                ListProjectBranchesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectBranchesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectBranchesSortOrder.Asc,
                "desc" => ListProjectBranchesSortOrder.Desc,
                _ => null,
            };
        }
    }
}