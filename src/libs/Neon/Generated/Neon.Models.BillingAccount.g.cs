
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingAccount
    {
        /// <summary>
        /// State of the billing account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BillingAccountStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BillingAccountState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.PaymentSource PaymentSource { get; set; }

        /// <summary>
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BillingSubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Indicates whether and how an account makes payments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BillingPaymentMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BillingPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The last time the quota was reset. Defaults to the date-time the account is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota_reset_at_last")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime QuotaResetAtLast { get; set; }

        /// <summary>
        /// The full name of the individual or entity that owns the billing account. This name appears on invoices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Billing email, to receive emails related to invoices and subscriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Billing address city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressCity { get; set; }

        /// <summary>
        /// Billing address country code defined by ISO 3166-1 alpha-2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressCountry { get; set; }

        /// <summary>
        /// Billing address country name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_country_name")]
        public string? AddressCountryName { get; set; }

        /// <summary>
        /// Billing address line 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_line1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressLine1 { get; set; }

        /// <summary>
        /// Billing address line 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_line2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressLine2 { get; set; }

        /// <summary>
        /// Billing address postal code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_postal_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressPostalCode { get; set; }

        /// <summary>
        /// Billing address state or region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddressState { get; set; }

        /// <summary>
        /// Orb user portal url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_portal_url")]
        public string? OrbPortalUrl { get; set; }

        /// <summary>
        /// The tax identification number for the billing account, displayed on invoices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public string? TaxId { get; set; }

        /// <summary>
        /// The type of the tax identification number based on the country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id_type")]
        public string? TaxIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_details")]
        public global::Neon.PlanDetails? PlanDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAccount" /> class.
        /// </summary>
        /// <param name="state">
        /// State of the billing account.
        /// </param>
        /// <param name="paymentSource"></param>
        /// <param name="subscriptionType">
        /// Type of subscription to Neon Cloud.<br/>
        /// Notice that for users without billing account this will be "UNKNOWN"
        /// </param>
        /// <param name="paymentMethod">
        /// Indicates whether and how an account makes payments.
        /// </param>
        /// <param name="quotaResetAtLast">
        /// The last time the quota was reset. Defaults to the date-time the account is created.
        /// </param>
        /// <param name="name">
        /// The full name of the individual or entity that owns the billing account. This name appears on invoices.
        /// </param>
        /// <param name="email">
        /// Billing email, to receive emails related to invoices and subscriptions.
        /// </param>
        /// <param name="addressCity">
        /// Billing address city.
        /// </param>
        /// <param name="addressCountry">
        /// Billing address country code defined by ISO 3166-1 alpha-2.
        /// </param>
        /// <param name="addressLine1">
        /// Billing address line 1.
        /// </param>
        /// <param name="addressLine2">
        /// Billing address line 2.
        /// </param>
        /// <param name="addressPostalCode">
        /// Billing address postal code.
        /// </param>
        /// <param name="addressState">
        /// Billing address state or region.
        /// </param>
        /// <param name="addressCountryName">
        /// Billing address country name.
        /// </param>
        /// <param name="orbPortalUrl">
        /// Orb user portal url
        /// </param>
        /// <param name="taxId">
        /// The tax identification number for the billing account, displayed on invoices.
        /// </param>
        /// <param name="taxIdType">
        /// The type of the tax identification number based on the country.
        /// </param>
        /// <param name="planDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingAccount(
            global::Neon.BillingAccountState state,
            global::Neon.PaymentSource paymentSource,
            global::Neon.BillingSubscriptionType subscriptionType,
            global::Neon.BillingPaymentMethod paymentMethod,
            global::System.DateTime quotaResetAtLast,
            string name,
            string email,
            string addressCity,
            string addressCountry,
            string addressLine1,
            string addressLine2,
            string addressPostalCode,
            string addressState,
            string? addressCountryName,
            string? orbPortalUrl,
            string? taxId,
            string? taxIdType,
            global::Neon.PlanDetails? planDetails)
        {
            this.State = state;
            this.PaymentSource = paymentSource ?? throw new global::System.ArgumentNullException(nameof(paymentSource));
            this.SubscriptionType = subscriptionType;
            this.PaymentMethod = paymentMethod;
            this.QuotaResetAtLast = quotaResetAtLast;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.AddressCity = addressCity ?? throw new global::System.ArgumentNullException(nameof(addressCity));
            this.AddressCountry = addressCountry ?? throw new global::System.ArgumentNullException(nameof(addressCountry));
            this.AddressCountryName = addressCountryName;
            this.AddressLine1 = addressLine1 ?? throw new global::System.ArgumentNullException(nameof(addressLine1));
            this.AddressLine2 = addressLine2 ?? throw new global::System.ArgumentNullException(nameof(addressLine2));
            this.AddressPostalCode = addressPostalCode ?? throw new global::System.ArgumentNullException(nameof(addressPostalCode));
            this.AddressState = addressState ?? throw new global::System.ArgumentNullException(nameof(addressState));
            this.OrbPortalUrl = orbPortalUrl;
            this.TaxId = taxId;
            this.TaxIdType = taxIdType;
            this.PlanDetails = planDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAccount" /> class.
        /// </summary>
        public BillingAccount()
        {
        }
    }
}