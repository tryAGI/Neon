#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Revoke project access<br/>
        /// Revokes project access from the user associated with the specified permission `id`. You can retrieve a user's permission `id` by listing project access.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="permissionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectPermission> RevokePermissionFromProjectAsync(
            string projectId,
            string permissionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}