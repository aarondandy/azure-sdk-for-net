// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    public partial class PolicySettings
    {
        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        public PolicySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        /// <param name="state">The state of the policy. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        /// <param name="mode">The mode of the policy. Possible values include:
        /// 'Prevention', 'Detection'</param>
        /// <param name="requestBodyCheck">Whether to allow WAF to check
        /// request Body.</param>
        /// <param name="maxRequestBodySizeInKb">Maximum request body size in
        /// Kb for WAF.</param>
        /// <param name="fileUploadLimitInMb">Maximum file upload size in Mb
        /// for WAF.</param>
        public PolicySettings(string state = default(string), string mode = default(string), bool? requestBodyCheck = default(bool?), int? maxRequestBodySizeInKb = default(int?), int? fileUploadLimitInMb = default(int?))
        {
            State = state;
            Mode = mode;
            RequestBodyCheck = requestBodyCheck;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadLimitInMb = fileUploadLimitInMb;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the policy. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the mode of the policy. Possible values include:
        /// 'Prevention', 'Detection'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets whether to allow WAF to check request Body.
        /// </summary>
        [JsonProperty(PropertyName = "requestBodyCheck")]
        public bool? RequestBodyCheck { get; set; }

        /// <summary>
        /// Gets or sets maximum request body size in Kb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "maxRequestBodySizeInKb")]
        public int? MaxRequestBodySizeInKb { get; set; }

        /// <summary>
        /// Gets or sets maximum file upload size in Mb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "fileUploadLimitInMb")]
        public int? FileUploadLimitInMb { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxRequestBodySizeInKb != null)
            {
                if (MaxRequestBodySizeInKb > 128)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxRequestBodySizeInKb", 128);
                }
                if (MaxRequestBodySizeInKb < 8)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxRequestBodySizeInKb", 8);
                }
            }
            if (FileUploadLimitInMb != null)
            {
                if (FileUploadLimitInMb < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "FileUploadLimitInMb", 0);
                }
            }
        }
    }
}
