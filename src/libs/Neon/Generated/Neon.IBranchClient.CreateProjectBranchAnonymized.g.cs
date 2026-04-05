#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Create anonymized branch<br/>
        /// Creates a new branch with anonymized data using PostgreSQL Anonymizer for static masking.<br/>
        /// This allows developers to work with masked production data.<br/>
        /// Optionally, provide `masking_rules` to set initial masking rules for the branch<br/>
        /// and `start_anonymization` to automatically start anonymization after creation. This<br/>
        /// combines functionality of updating masking rules and starting anonymization into the<br/>
        /// branch creation request.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAnonymizedAsync(
            string projectId,

            global::Neon.BranchAnonymizedCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create anonymized branch<br/>
        /// Creates a new branch with anonymized data using PostgreSQL Anonymizer for static masking.<br/>
        /// This allows developers to work with masked production data.<br/>
        /// Optionally, provide `masking_rules` to set initial masking rules for the branch<br/>
        /// and `start_anonymization` to automatically start anonymization after creation. This<br/>
        /// combines functionality of updating masking rules and starting anonymization into the<br/>
        /// branch creation request.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAnonymizedAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}