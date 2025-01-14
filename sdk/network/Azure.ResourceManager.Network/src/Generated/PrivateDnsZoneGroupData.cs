// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PrivateDnsZoneGroup data model. </summary>
    public partial class PrivateDnsZoneGroupData : NetworkSubResource
    {
        /// <summary> Initializes a new instance of PrivateDnsZoneGroupData. </summary>
        public PrivateDnsZoneGroupData()
        {
            PrivateDnsZoneConfigs = new ChangeTrackingList<PrivateDnsZoneConfig>();
        }

        /// <summary> Initializes a new instance of PrivateDnsZoneGroupData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the private dns zone group resource. </param>
        /// <param name="privateDnsZoneConfigs"> A collection of private dns zone configurations of the private dns zone group. </param>
        internal PrivateDnsZoneGroupData(ResourceIdentifier id, string name, string etag, NetworkProvisioningState? provisioningState, IList<PrivateDnsZoneConfig> privateDnsZoneConfigs) : base(id)
        {
            Name = name;
            Etag = etag;
            ProvisioningState = provisioningState;
            PrivateDnsZoneConfigs = privateDnsZoneConfigs;
        }

        /// <summary> Name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The provisioning state of the private dns zone group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A collection of private dns zone configurations of the private dns zone group. </summary>
        public IList<PrivateDnsZoneConfig> PrivateDnsZoneConfigs { get; }
    }
}
