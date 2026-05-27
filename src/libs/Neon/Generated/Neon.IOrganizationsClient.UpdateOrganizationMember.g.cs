#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update role for organization member<br/>
        /// Updates the role of an existing member in the specified organization.<br/>
        /// Supported roles are `admin` and `member`.<br/>
        /// Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Member> UpdateOrganizationMemberAsync(
            string orgId,
            string memberId,

            global::Neon.OrganizationMemberUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update role for organization member<br/>
        /// Updates the role of an existing member in the specified organization.<br/>
        /// Supported roles are `admin` and `member`.<br/>
        /// Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.Member>> UpdateOrganizationMemberAsResponseAsync(
            string orgId,
            string memberId,

            global::Neon.OrganizationMemberUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update role for organization member<br/>
        /// Updates the role of an existing member in the specified organization.<br/>
        /// Supported roles are `admin` and `member`.<br/>
        /// Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="role">
        /// The role of the organization member
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Member> UpdateOrganizationMemberAsync(
            string orgId,
            string memberId,
            global::Neon.MemberRole role,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}