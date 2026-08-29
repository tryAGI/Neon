
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionResponse
    {
        /// <summary>
        /// Cloud region where the resource's Postgres compute and storage reside (for example, `aws-us-east-1`). Valid values are returned by `GET /regions`.<br/>
        /// Example: aws-us-east-1
        /// </summary>
        /// <example>aws-us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionId { get; set; }

        /// <summary>
        /// A short description of the region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// True if this region is selected by default when no region is specified during project creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// The geographical latitude (approximate) for the region. Empty if unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo_lat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeoLat { get; set; }

        /// <summary>
        /// The geographical longitude (approximate) for the region. Empty if unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo_long")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeoLong { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionResponse" /> class.
        /// </summary>
        /// <param name="regionId">
        /// Cloud region where the resource's Postgres compute and storage reside (for example, `aws-us-east-1`). Valid values are returned by `GET /regions`.<br/>
        /// Example: aws-us-east-1
        /// </param>
        /// <param name="name">
        /// A short description of the region.
        /// </param>
        /// <param name="default">
        /// True if this region is selected by default when no region is specified during project creation.
        /// </param>
        /// <param name="geoLat">
        /// The geographical latitude (approximate) for the region. Empty if unknown.
        /// </param>
        /// <param name="geoLong">
        /// The geographical longitude (approximate) for the region. Empty if unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionResponse(
            string regionId,
            string name,
            bool @default,
            string geoLat,
            string geoLong)
        {
            this.RegionId = regionId ?? throw new global::System.ArgumentNullException(nameof(regionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Default = @default;
            this.GeoLat = geoLat ?? throw new global::System.ArgumentNullException(nameof(geoLat));
            this.GeoLong = geoLong ?? throw new global::System.ArgumentNullException(nameof(geoLong));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionResponse" /> class.
        /// </summary>
        public RegionResponse()
        {
        }

    }
}