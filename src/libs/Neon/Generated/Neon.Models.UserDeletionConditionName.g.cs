
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserDeletionConditionName
    {
        /// <summary>
        /// 
        /// </summary>
        OrgAdminMembershipCount,
        /// <summary>
        /// 
        /// </summary>
        ProjectCount,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserDeletionConditionNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserDeletionConditionName value)
        {
            return value switch
            {
                UserDeletionConditionName.OrgAdminMembershipCount => "org_admin_membership_count",
                UserDeletionConditionName.ProjectCount => "project_count",
                UserDeletionConditionName.SubscriptionType => "subscription_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserDeletionConditionName? ToEnum(string value)
        {
            return value switch
            {
                "org_admin_membership_count" => UserDeletionConditionName.OrgAdminMembershipCount,
                "project_count" => UserDeletionConditionName.ProjectCount,
                "subscription_type" => UserDeletionConditionName.SubscriptionType,
                _ => null,
            };
        }
    }
}