// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI gateway datasource collection
    /// </summary>
    public partial class ODataResponseListGatewayDatasource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListGatewayDatasource class.
        /// </summary>
        public ODataResponseListGatewayDatasource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListGatewayDatasource class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">List of gateway datasources</param>
        public ODataResponseListGatewayDatasource(string odatacontext = default(string), IList<GatewayDatasource> value = default(IList<GatewayDatasource>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets list of gateway datasources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GatewayDatasource> Value { get; set; }

    }
}
