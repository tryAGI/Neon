
#nullable enable

namespace Neon
{
    /// <summary>
    /// The feature to enable for the organization
    /// </summary>
    public enum EnableOrganizationFeatureRequestFeature
    {
        /// <summary>
        /// 
        /// </summary>
        AllowHipaaProjects,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnableOrganizationFeatureRequestFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnableOrganizationFeatureRequestFeature value)
        {
            return value switch
            {
                EnableOrganizationFeatureRequestFeature.AllowHipaaProjects => "allow_hipaa_projects",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnableOrganizationFeatureRequestFeature? ToEnum(string value)
        {
            return value switch
            {
                "allow_hipaa_projects" => EnableOrganizationFeatureRequestFeature.AllowHipaaProjects,
                _ => null,
            };
        }
    }
}