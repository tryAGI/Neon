
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgDeletionConditionName
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgDeletionConditionNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgDeletionConditionName value)
        {
            return value switch
            {
                OrgDeletionConditionName.ProjectCount => "project_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgDeletionConditionName? ToEnum(string value)
        {
            return value switch
            {
                "project_count" => OrgDeletionConditionName.ProjectCount,
                _ => null,
            };
        }
    }
}