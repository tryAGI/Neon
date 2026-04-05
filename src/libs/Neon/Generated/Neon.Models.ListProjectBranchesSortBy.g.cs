
#nullable enable

namespace Neon
{
    /// <summary>
    /// Default Value: updated_at
    /// </summary>
    public enum ListProjectBranchesSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectBranchesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectBranchesSortBy value)
        {
            return value switch
            {
                ListProjectBranchesSortBy.CreatedAt => "created_at",
                ListProjectBranchesSortBy.Name => "name",
                ListProjectBranchesSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectBranchesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListProjectBranchesSortBy.CreatedAt,
                "name" => ListProjectBranchesSortBy.Name,
                "updated_at" => ListProjectBranchesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}