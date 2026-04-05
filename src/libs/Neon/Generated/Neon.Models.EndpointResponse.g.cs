
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointResponse
    {
        /// <summary>
        /// Example: {"host":"ep-silent-smoke-806639.us-east-2.aws.neon.tech","id":"ep-silent-smoke-806639","name":"My cool compute","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","autoscaling_limit_min_cu":1,"autoscaling_limit_max_cu":1,"region_id":"aws-us-east-2","type":"read_write","current_state":"init","pending_state":"active","settings":{"pg_settings":{}},"pooler_enabled":false,"pooler_mode":"transaction","disabled":false,"passwordless_access":true,"creation_source":"console","created_at":"2022-12-03T15:37:07Z","updated_at":"2022-12-03T15:37:07Z","proxy_host":"us-east-2.aws.neon.tech","suspend_timeout_seconds":0,"provisioner":"k8s-neonvm"}
        /// </summary>
        /// <example>{"host":"ep-silent-smoke-806639.us-east-2.aws.neon.tech","id":"ep-silent-smoke-806639","name":"My cool compute","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","autoscaling_limit_min_cu":1,"autoscaling_limit_max_cu":1,"region_id":"aws-us-east-2","type":"read_write","current_state":"init","pending_state":"active","settings":{"pg_settings":{}},"pooler_enabled":false,"pooler_mode":"transaction","disabled":false,"passwordless_access":true,"creation_source":"console","created_at":"2022-12-03T15:37:07Z","updated_at":"2022-12-03T15:37:07Z","proxy_host":"us-east-2.aws.neon.tech","suspend_timeout_seconds":0,"provisioner":"k8s-neonvm"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Endpoint Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// Example: {"host":"ep-silent-smoke-806639.us-east-2.aws.neon.tech","id":"ep-silent-smoke-806639","name":"My cool compute","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","autoscaling_limit_min_cu":1,"autoscaling_limit_max_cu":1,"region_id":"aws-us-east-2","type":"read_write","current_state":"init","pending_state":"active","settings":{"pg_settings":{}},"pooler_enabled":false,"pooler_mode":"transaction","disabled":false,"passwordless_access":true,"creation_source":"console","created_at":"2022-12-03T15:37:07Z","updated_at":"2022-12-03T15:37:07Z","proxy_host":"us-east-2.aws.neon.tech","suspend_timeout_seconds":0,"provisioner":"k8s-neonvm"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointResponse(
            global::Neon.Endpoint endpoint)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse" /> class.
        /// </summary>
        public EndpointResponse()
        {
        }
    }
}