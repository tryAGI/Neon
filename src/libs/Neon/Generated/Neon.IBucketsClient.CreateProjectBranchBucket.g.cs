#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Create a bucket on the branch<br/>
        /// Creates a new branchable object-storage bucket on the specified branch.<br/>
        /// Buckets are managed by the Neon Platform branchable-storage service.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BucketResponse> CreateProjectBranchBucketAsync(
            string projectId,
            string branchId,

            global::Neon.BucketCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a bucket on the branch<br/>
        /// Creates a new branchable object-storage bucket on the specified branch.<br/>
        /// Buckets are managed by the Neon Platform branchable-storage service.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BucketResponse>> CreateProjectBranchBucketAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.BucketCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a bucket on the branch<br/>
        /// Creates a new branchable object-storage bucket on the specified branch.<br/>
        /// Buckets are managed by the Neon Platform branchable-storage service.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="name">
        /// The bucket name.
        /// </param>
        /// <param name="accessLevel">
        /// Access level for the bucket. Defaults to `private`. Set to `public_read`<br/>
        /// to allow anonymous `GetObject`/`HeadObject` on objects in this bucket.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BucketResponse> CreateProjectBranchBucketAsync(
            string projectId,
            string branchId,
            string name,
            global::Neon.BucketCreateRequestAccessLevel? accessLevel = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}