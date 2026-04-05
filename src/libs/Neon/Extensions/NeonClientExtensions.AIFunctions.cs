#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Neon;

/// <summary>
/// Extensions for using NeonClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static partial class NeonClientExtensions
{
    /// <summary>
    /// Returns all AIFunction tools for the Neon client.
    /// </summary>
    /// <param name="client">The Neon client to use.</param>
    /// <returns>A list of AIFunction tools.</returns>
    [CLSCompliant(false)]
    public static IList<AIFunction> AsTools(this NeonClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsListProjectsTool(),
            client.AsCreateProjectTool(),
            client.AsListBranchesTool(),
            client.AsGetConnectionUriTool(),
        ];
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all Neon projects,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Neon client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListProjectsTool(this NeonClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Search query to filter projects by name")] string? search = null,
                   [Description("Maximum number of projects to return (default 10)")] int limit = 10,
                   [Description("Organization ID to list projects for")] string? orgId = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Project.ListProjectsAsync(
                    search: search,
                    limit: limit,
                    orgId: orgId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "NeonListProjects",
            description: "Lists Neon serverless Postgres projects. Returns project names, IDs, regions, Postgres versions, and creation dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new Neon project,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Neon client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateProjectTool(this NeonClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Name for the new project")] string? name = null,
                   [Description("Region ID (e.g., 'aws-us-east-1'). See Neon docs for available regions.")] string? regionId = null,
                   [Description("Major Postgres version (14, 15, 16, 17, or 18). Default is 17.")] int? pgVersion = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Project.CreateProjectAsync(
                    project: new ProjectCreateRequestProject
                    {
                        Name = name,
                        RegionId = regionId,
                        PgVersion = pgVersion,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "NeonCreateProject",
            description: "Creates a new Neon serverless Postgres project. Optionally specify a name, region, and Postgres version. Returns the new project details, connection URIs, default roles, and databases.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists branches for a Neon project,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Neon client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListBranchesTool(this NeonClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Neon project ID to list branches for")] string projectId,
                   [Description("Search query to filter branches by name")] string? search = null,
                   [Description("Maximum number of branches to return")] int? limit = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Branch.ListProjectBranchesAsync(
                    projectId: projectId,
                    search: search,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "NeonListBranches",
            description: "Lists branches for a Neon project. Each project has a root 'main' branch and may have child branches. Returns branch names, IDs, parent relationships, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets a connection URI for a Neon database,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Neon client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetConnectionUriTool(this NeonClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Neon project ID")] string projectId,
                   [Description("The database name to connect to")] string databaseName,
                   [Description("The role name to connect as")] string roleName,
                   [Description("The branch ID (optional, defaults to the project's default branch)")] string? branchId = null,
                   [Description("Whether to use connection pooling")] bool? pooled = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Project.GetConnectionURIAsync(
                    projectId: projectId,
                    databaseName: databaseName,
                    roleName: roleName,
                    branchId: branchId,
                    pooled: pooled,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "NeonGetConnectionUri",
            description: "Gets a PostgreSQL connection URI for a specific database in a Neon project. Requires the project ID, database name, and role name. Optionally specify a branch and pooling mode.");
    }
}
