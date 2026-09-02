#nullable enable

namespace Neon
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Rotate a credential's secrets<br/>
        /// Replaces the secret material on an existing scoped credential in<br/>
        /// place. `token_id` is preserved — it is the `AWS_ACCESS_KEY_ID` for<br/>
        /// S3-compatible clients, so the access key id your application already<br/>
        /// holds keeps working and only the secret changes. This is the analog of<br/>
        /// resetting a Postgres password, not of issuing a second credential.<br/>
        /// The response carries the new `api_token` and `s3_secret_access_key`<br/>
        /// exactly once. Rotation is **not** idempotent: retrying after an<br/>
        /// ambiguous timeout mints another secret and supersedes the previous<br/>
        /// replacement, so a retry does not recover a lost response — it only<br/>
        /// invalidates the secret you did not receive. If you lose the response,<br/>
        /// issue a replacement credential and revoke this one.<br/>
        /// The old secret stops authenticating as soon as the rotation commits.<br/>
        /// Where a region caches credentials on its data-plane verifiers, a<br/>
        /// replica may briefly keep accepting the old secret — and rejecting the<br/>
        /// new one — until its cache entry expires; where it does not, the<br/>
        /// cutover is immediate apart from requests already in flight. Either way<br/>
        /// the changeover is not atomic across replicas, so retry an unexpected<br/>
        /// authentication failure right after rotating rather than treating the<br/>
        /// new secret as bad. `last_used_at` continues to report the logical<br/>
        /// credential's prior usage and says nothing about whether the new secret<br/>
        /// has been used yet.<br/>
        /// Only a live, unexpired, unrevoked customer-managed (`user`) credential<br/>
        /// on a live project and live branch is eligible. Anything else —<br/>
        /// including the platform-internal `function` and `system` credentials —<br/>
        /// is reported as not found, indistinguishable from an unknown<br/>
        /// `token_id`.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RotateCredentialResponse> RotateCredentialAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a credential's secrets<br/>
        /// Replaces the secret material on an existing scoped credential in<br/>
        /// place. `token_id` is preserved — it is the `AWS_ACCESS_KEY_ID` for<br/>
        /// S3-compatible clients, so the access key id your application already<br/>
        /// holds keeps working and only the secret changes. This is the analog of<br/>
        /// resetting a Postgres password, not of issuing a second credential.<br/>
        /// The response carries the new `api_token` and `s3_secret_access_key`<br/>
        /// exactly once. Rotation is **not** idempotent: retrying after an<br/>
        /// ambiguous timeout mints another secret and supersedes the previous<br/>
        /// replacement, so a retry does not recover a lost response — it only<br/>
        /// invalidates the secret you did not receive. If you lose the response,<br/>
        /// issue a replacement credential and revoke this one.<br/>
        /// The old secret stops authenticating as soon as the rotation commits.<br/>
        /// Where a region caches credentials on its data-plane verifiers, a<br/>
        /// replica may briefly keep accepting the old secret — and rejecting the<br/>
        /// new one — until its cache entry expires; where it does not, the<br/>
        /// cutover is immediate apart from requests already in flight. Either way<br/>
        /// the changeover is not atomic across replicas, so retry an unexpected<br/>
        /// authentication failure right after rotating rather than treating the<br/>
        /// new secret as bad. `last_used_at` continues to report the logical<br/>
        /// credential's prior usage and says nothing about whether the new secret<br/>
        /// has been used yet.<br/>
        /// Only a live, unexpired, unrevoked customer-managed (`user`) credential<br/>
        /// on a live project and live branch is eligible. Anything else —<br/>
        /// including the platform-internal `function` and `system` credentials —<br/>
        /// is reported as not found, indistinguishable from an unknown<br/>
        /// `token_id`.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.RotateCredentialResponse>> RotateCredentialAsResponseAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}