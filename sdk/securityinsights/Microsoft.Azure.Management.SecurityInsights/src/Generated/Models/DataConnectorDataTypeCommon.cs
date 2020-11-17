// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Common field for data type in data connectors.
    /// </summary>
    public partial class DataConnectorDataTypeCommon
    {
        /// <summary>
        /// Initializes a new instance of the DataConnectorDataTypeCommon
        /// class.
        /// </summary>
        public DataConnectorDataTypeCommon()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataConnectorDataTypeCommon
        /// class.
        /// </summary>
        /// <param name="state">Describe whether this data type connection is
        /// enabled or not. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public DataConnectorDataTypeCommon(string state = default(string))
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describe whether this data type connection is enabled
        /// or not. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

    }
}
