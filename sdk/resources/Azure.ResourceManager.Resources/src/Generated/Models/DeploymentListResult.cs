// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of deployments. </summary>
    public partial class DeploymentListResult
    {
        /// <summary> Initializes a new instance of DeploymentListResult. </summary>
        internal DeploymentListResult()
        {
        }

        /// <summary> Initializes a new instance of DeploymentListResult. </summary>
        /// <param name="value"> An array of deployments. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DeploymentListResult(IReadOnlyList<DeploymentExtended> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of deployments. </summary>
        public IReadOnlyList<DeploymentExtended> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}