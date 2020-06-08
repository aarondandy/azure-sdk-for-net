// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The path of the SAP ECC OData entity. </summary>
    public partial class SapEccResourceDataset : Dataset
    {
        /// <summary> Initializes a new instance of SapEccResourceDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="path"> The path of the SAP ECC OData entity. Type: string (or Expression with resultType string). </param>
        public SapEccResourceDataset(LinkedServiceReference linkedServiceName, object path) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            Path = path;
            Type = "SapEccResource";
        }

        /// <summary> Initializes a new instance of SapEccResourceDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="path"> The path of the SAP ECC OData entity. Type: string (or Expression with resultType string). </param>
        internal SapEccResourceDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object path) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Path = path;
            Type = type ?? "SapEccResource";
        }

        /// <summary> The path of the SAP ECC OData entity. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
    }
}