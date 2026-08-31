#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Register a custom domain on a branch<br/>
        /// Registers a customer-owned domain (for example `dashboard.acme.com`) on the<br/>
        /// branch and points it at a target entity, chosen by `entity_type` +<br/>
        /// `entity_id`. In v1 only `entity_type: function` is supported (an<br/>
        /// unsupported type is rejected with `400`), where `entity_id` is the function<br/>
        /// slug and the function must already exist on the branch (else `404`).<br/>
        /// The response includes the `cname_target` the customer must point their<br/>
        /// domain at with a CNAME record; the domain goes live only once that DNS<br/>
        /// resolves and a certificate is issued on the first request. A domain already<br/>
        /// registered to another resource is rejected with `409` and no detail about<br/>
        /// the owner. Re-registering the same domain for the same entity is idempotent.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CustomDomain> RegisterProjectBranchCustomDomainAsync(
            string projectId,
            string branchId,

            global::Neon.CustomDomainRegisterRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a custom domain on a branch<br/>
        /// Registers a customer-owned domain (for example `dashboard.acme.com`) on the<br/>
        /// branch and points it at a target entity, chosen by `entity_type` +<br/>
        /// `entity_id`. In v1 only `entity_type: function` is supported (an<br/>
        /// unsupported type is rejected with `400`), where `entity_id` is the function<br/>
        /// slug and the function must already exist on the branch (else `404`).<br/>
        /// The response includes the `cname_target` the customer must point their<br/>
        /// domain at with a CNAME record; the domain goes live only once that DNS<br/>
        /// resolves and a certificate is issued on the first request. A domain already<br/>
        /// registered to another resource is rejected with `409` and no detail about<br/>
        /// the owner. Re-registering the same domain for the same entity is idempotent.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.CustomDomain>> RegisterProjectBranchCustomDomainAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.CustomDomainRegisterRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a custom domain on a branch<br/>
        /// Registers a customer-owned domain (for example `dashboard.acme.com`) on the<br/>
        /// branch and points it at a target entity, chosen by `entity_type` +<br/>
        /// `entity_id`. In v1 only `entity_type: function` is supported (an<br/>
        /// unsupported type is rejected with `400`), where `entity_id` is the function<br/>
        /// slug and the function must already exist on the branch (else `404`).<br/>
        /// The response includes the `cname_target` the customer must point their<br/>
        /// domain at with a CNAME record; the domain goes live only once that DNS<br/>
        /// resolves and a certificate is issued on the first request. A domain already<br/>
        /// registered to another resource is rejected with `409` and no detail about<br/>
        /// the owner. Re-registering the same domain for the same entity is idempotent.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="domain">
        /// The custom domain to register (for example `dashboard.acme.com`).<br/>
        /// Case-insensitive; normalized to lowercase (a trailing root dot is<br/>
        /// stripped, so the 254-char bound admits a fully-qualified name whose<br/>
        /// normalized form is 253 chars). Neon-managed and internal hostnames are<br/>
        /// rejected.
        /// </param>
        /// <param name="entityType">
        /// The kind of branch entity to point the domain at. v1 supports only<br/>
        /// `function`; any other value is rejected with `invalid_entity_type`.<br/>
        /// Example: function
        /// </param>
        /// <param name="entityId">
        /// The target entity's identifier within the branch. For `function` this<br/>
        /// is the function slug (which must already exist on the branch).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CustomDomain> RegisterProjectBranchCustomDomainAsync(
            string projectId,
            string branchId,
            string domain,
            string entityType,
            string entityId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}