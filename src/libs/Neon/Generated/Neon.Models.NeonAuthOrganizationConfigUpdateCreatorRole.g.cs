
#nullable enable

namespace Neon
{
    /// <summary>
    /// The role assigned to the user who creates an organization
    /// </summary>
    public enum NeonAuthOrganizationConfigUpdateCreatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthOrganizationConfigUpdateCreatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthOrganizationConfigUpdateCreatorRole value)
        {
            return value switch
            {
                NeonAuthOrganizationConfigUpdateCreatorRole.Admin => "admin",
                NeonAuthOrganizationConfigUpdateCreatorRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthOrganizationConfigUpdateCreatorRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => NeonAuthOrganizationConfigUpdateCreatorRole.Admin,
                "owner" => NeonAuthOrganizationConfigUpdateCreatorRole.Owner,
                _ => null,
            };
        }
    }
}