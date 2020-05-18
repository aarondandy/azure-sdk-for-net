// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The Device. </summary>
    public partial class DeviceIdentity
    {
        /// <summary> Initializes a new instance of DeviceIdentity. </summary>
        public DeviceIdentity()
        {
        }

        /// <summary> Initializes a new instance of DeviceIdentity. </summary>
        /// <param name="deviceId"> The unique identifier of this device. </param>
        /// <param name="generationId"> An IoT hub-generated, case-sensitive string up to 128 characters long. This value is used to distinguish devices with the same deviceId, when they have been deleted and re-created. </param>
        /// <param name="etag"> A string representing a weak ETag for the device identity, as per RFC7232. </param>
        /// <param name="connectionState"> Tells whether the device is connected or not. </param>
        /// <param name="status"> Flags whether a device is enabled or not. If disabled, a device cannot connect to the service. </param>
        /// <param name="statusReason"> A 128 character-long string that stores the reason for the device identity status. All UTF-8 characters are allowed. </param>
        /// <param name="connectionStateUpdatedTime"> A temporal indicator, showing the date and last time the connection state was updated. </param>
        /// <param name="statusUpdatedTime"> The last timestamp of when the status field was updated. </param>
        /// <param name="lastActivityTime"> A temporal indicator, showing the date and last time the device connected, received, or sent a message. </param>
        /// <param name="cloudToDeviceMessageCount"> The number of cloud to device messages currently queued to be sent to the device. </param>
        /// <param name="authentication"> The details on what authentication mechanisms are used by this device. </param>
        /// <param name="capabilities"> The set of capabilities that this device has. For example, if this device is an edge device or not. </param>
        /// <param name="deviceScope"> The scope that this device belongs to. </param>
        /// <param name="parentScopes"> TODO: service team needs to explain this. </param>
        internal DeviceIdentity(string deviceId, string generationId, string etag, DeviceConnectionState? connectionState, DeviceStatus? status, string statusReason, DateTimeOffset? connectionStateUpdatedTime, DateTimeOffset? statusUpdatedTime, DateTimeOffset? lastActivityTime, int? cloudToDeviceMessageCount, AuthenticationMechanism authentication, DeviceCapabilities capabilities, string deviceScope, IList<string> parentScopes)
        {
            DeviceId = deviceId;
            GenerationId = generationId;
            Etag = etag;
            ConnectionState = connectionState;
            Status = status;
            StatusReason = statusReason;
            ConnectionStateUpdatedTime = connectionStateUpdatedTime;
            StatusUpdatedTime = statusUpdatedTime;
            LastActivityTime = lastActivityTime;
            CloudToDeviceMessageCount = cloudToDeviceMessageCount;
            Authentication = authentication;
            Capabilities = capabilities;
            DeviceScope = deviceScope;
            ParentScopes = parentScopes;
        }

        /// <summary> The unique identifier of this device. </summary>
        public string DeviceId { get; set; }
        /// <summary> An IoT hub-generated, case-sensitive string up to 128 characters long. This value is used to distinguish devices with the same deviceId, when they have been deleted and re-created. </summary>
        public string GenerationId { get; set; }
        /// <summary> A string representing a weak ETag for the device identity, as per RFC7232. </summary>
        public string Etag { get; set; }
        /// <summary> Tells whether the device is connected or not. </summary>
        public DeviceConnectionState? ConnectionState { get; set; }
        /// <summary> Flags whether a device is enabled or not. If disabled, a device cannot connect to the service. </summary>
        public DeviceStatus? Status { get; set; }
        /// <summary> A 128 character-long string that stores the reason for the device identity status. All UTF-8 characters are allowed. </summary>
        public string StatusReason { get; set; }
        /// <summary> A temporal indicator, showing the date and last time the connection state was updated. </summary>
        public DateTimeOffset? ConnectionStateUpdatedTime { get; set; }
        /// <summary> The last timestamp of when the status field was updated. </summary>
        public DateTimeOffset? StatusUpdatedTime { get; set; }
        /// <summary> A temporal indicator, showing the date and last time the device connected, received, or sent a message. </summary>
        public DateTimeOffset? LastActivityTime { get; set; }
        /// <summary> The number of cloud to device messages currently queued to be sent to the device. </summary>
        public int? CloudToDeviceMessageCount { get; set; }
        /// <summary> The details on what authentication mechanisms are used by this device. </summary>
        public AuthenticationMechanism Authentication { get; set; }
        /// <summary> The set of capabilities that this device has. For example, if this device is an edge device or not. </summary>
        public DeviceCapabilities Capabilities { get; set; }
        /// <summary> The scope that this device belongs to. </summary>
        public string DeviceScope { get; set; }
        /// <summary> TODO: service team needs to explain this. </summary>
        public IList<string> ParentScopes { get; set; }
    }
}