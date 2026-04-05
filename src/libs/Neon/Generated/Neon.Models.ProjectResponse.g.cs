
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectResponse
    {
        /// <summary>
        /// Example: {"id":"spring-example-302709","platform_id":"aws","region_id":"aws-us-east-2","name":"spring-example-302709","provisioner":"k8s-pod","pg_version":15,"proxy_host":"us-east-2.aws.neon.tech","store_passwords":true,"creation_source":"console","history_retention_seconds":604800,"created_at":"2022-12-13T01:30:55Z","updated_at":"2022-12-13T01:30:55Z","owner":{"name":"John Smith","email":"some@email.com","branches_limit":10,"subscription_type":"scale"},"org_id":"org-morning-bread-81040908","owner_id":"629982cc-de05-43db-ae16-28f2399c4910","data_storage_bytes_hour":2831928,"branch_logical_size_limit":10,"branch_logical_size_limit_bytes":10485760,"data_transfer_bytes":1000,"written_data_bytes":193990002,"compute_time_seconds":2485760,"active_time_seconds":621440,"cpu_used_sec":155350,"consumption_period_start":"2022-11-01T00:00:00Z","consumption_period_end":"2022-12-01T00:00:00Z"}
        /// </summary>
        /// <example>{"id":"spring-example-302709","platform_id":"aws","region_id":"aws-us-east-2","name":"spring-example-302709","provisioner":"k8s-pod","pg_version":15,"proxy_host":"us-east-2.aws.neon.tech","store_passwords":true,"creation_source":"console","history_retention_seconds":604800,"created_at":"2022-12-13T01:30:55Z","updated_at":"2022-12-13T01:30:55Z","owner":{"name":"John Smith","email":"some@email.com","branches_limit":10,"subscription_type":"scale"},"org_id":"org-morning-bread-81040908","owner_id":"629982cc-de05-43db-ae16-28f2399c4910","data_storage_bytes_hour":2831928,"branch_logical_size_limit":10,"branch_logical_size_limit_bytes":10485760,"data_transfer_bytes":1000,"written_data_bytes":193990002,"compute_time_seconds":2485760,"active_time_seconds":621440,"cpu_used_sec":155350,"consumption_period_start":"2022-11-01T00:00:00Z","consumption_period_end":"2022-12-01T00:00:00Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Project Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        /// <param name="project">
        /// Example: {"id":"spring-example-302709","platform_id":"aws","region_id":"aws-us-east-2","name":"spring-example-302709","provisioner":"k8s-pod","pg_version":15,"proxy_host":"us-east-2.aws.neon.tech","store_passwords":true,"creation_source":"console","history_retention_seconds":604800,"created_at":"2022-12-13T01:30:55Z","updated_at":"2022-12-13T01:30:55Z","owner":{"name":"John Smith","email":"some@email.com","branches_limit":10,"subscription_type":"scale"},"org_id":"org-morning-bread-81040908","owner_id":"629982cc-de05-43db-ae16-28f2399c4910","data_storage_bytes_hour":2831928,"branch_logical_size_limit":10,"branch_logical_size_limit_bytes":10485760,"data_transfer_bytes":1000,"written_data_bytes":193990002,"compute_time_seconds":2485760,"active_time_seconds":621440,"cpu_used_sec":155350,"consumption_period_start":"2022-11-01T00:00:00Z","consumption_period_end":"2022-12-01T00:00:00Z"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectResponse(
            global::Neon.Project project)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        public ProjectResponse()
        {
        }
    }
}