
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthWebhookConfigEnabledEvent
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationInvitationAccepted,
        /// <summary>
        /// 
        /// </summary>
        OrganizationInvitationCreated,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberVerified,
        /// <summary>
        /// 
        /// </summary>
        SendMagicLink,
        /// <summary>
        /// 
        /// </summary>
        SendOtp,
        /// <summary>
        /// 
        /// </summary>
        UserBeforeCreate,
        /// <summary>
        /// 
        /// </summary>
        UserCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthWebhookConfigEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthWebhookConfigEnabledEvent value)
        {
            return value switch
            {
                NeonAuthWebhookConfigEnabledEvent.OrganizationInvitationAccepted => "organization.invitation.accepted",
                NeonAuthWebhookConfigEnabledEvent.OrganizationInvitationCreated => "organization.invitation.created",
                NeonAuthWebhookConfigEnabledEvent.PhoneNumberVerified => "phone_number.verified",
                NeonAuthWebhookConfigEnabledEvent.SendMagicLink => "send.magic_link",
                NeonAuthWebhookConfigEnabledEvent.SendOtp => "send.otp",
                NeonAuthWebhookConfigEnabledEvent.UserBeforeCreate => "user.before_create",
                NeonAuthWebhookConfigEnabledEvent.UserCreated => "user.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthWebhookConfigEnabledEvent? ToEnum(string value)
        {
            return value switch
            {
                "organization.invitation.accepted" => NeonAuthWebhookConfigEnabledEvent.OrganizationInvitationAccepted,
                "organization.invitation.created" => NeonAuthWebhookConfigEnabledEvent.OrganizationInvitationCreated,
                "phone_number.verified" => NeonAuthWebhookConfigEnabledEvent.PhoneNumberVerified,
                "send.magic_link" => NeonAuthWebhookConfigEnabledEvent.SendMagicLink,
                "send.otp" => NeonAuthWebhookConfigEnabledEvent.SendOtp,
                "user.before_create" => NeonAuthWebhookConfigEnabledEvent.UserBeforeCreate,
                "user.created" => NeonAuthWebhookConfigEnabledEvent.UserCreated,
                _ => null,
            };
        }
    }
}