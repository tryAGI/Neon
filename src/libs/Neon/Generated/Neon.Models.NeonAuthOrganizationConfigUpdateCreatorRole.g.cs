
#nullable enable

namespace Neon
{
    /// <summary>
    /// Role of the organization's creator. `owner`: full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
    /// </summary>
    public enum NeonAuthOrganizationConfigUpdateCreatorRole
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