
#nullable enable

namespace Neon
{
    /// <summary>
    /// Role of the organization's creator. `owner`: full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.<br/>
    /// Default Value: owner
    /// </summary>
    public enum NeonAuthOrganizationConfigCreatorRole
    {
        /// <summary>
        /// full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
        /// </summary>
        Admin,
        /// <summary>
        /// full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
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