#nullable enable

namespace Neon
{
    public partial interface IOperationClient
    {
        /// <summary>
        /// Retrieve operation details<br/>
        /// Retrieves details for the specified operation.<br/>
        /// An operation is an action performed on a Neon project resource.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain a `operation_id` by listing operations for the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OperationResponse> GetProjectOperationAsync(
            string projectId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}