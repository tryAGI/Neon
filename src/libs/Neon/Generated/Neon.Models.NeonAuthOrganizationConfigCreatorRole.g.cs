
#nullable enable

namespace Neon
{
    /// <summary>
    /// The role assigned to the user who creates an organization<br/>
    /// Default Value: owner
    /// </summary>
    public enum NeonAuthOrganizationConfigCreatorRole
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
    public static class NeonAuthOrganizationConfigCreatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthOrganizationConfigCreatorRole value)
        {
            return value switch
            {
                NeonAuthOrganizationConfigCreatorRole.Admin => "admin",
                NeonAuthOrganizationConfigCreatorRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthOrganizationConfigCreatorRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => NeonAuthOrganizationConfigCreatorRole.Admin,
                "owner" => NeonAuthOrganizationConfigCreatorRole.Owner,
                _ => null,
            };
        }
    }
}