// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the origin. </summary>
    internal partial class OriginProperties : OriginUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of OriginProperties. </summary>
        internal OriginProperties()
        {
        }

        /// <summary> Resource status of the origin. </summary>
        public OriginResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the origin. </summary>
        public OriginProvisioningState? ProvisioningState { get; }
        /// <summary> The approval status for the connection to the Private Link. </summary>
        public PrivateEndpointStatus? PrivateEndpointStatus { get; }
    }
}
