// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties required to create an endpoint. </summary>
    internal partial class EndpointProperties : EndpointPropertiesUpdateParameters
    {
        /// <summary> Initializes a new instance of EndpointProperties. </summary>
        /// <param name="origins"> The source of the content being delivered via CDN. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="origins"/> is null. </exception>
        internal EndpointProperties(IEnumerable<DeepCreatedOrigin> origins)
        {
            if (origins == null)
            {
                throw new ArgumentNullException(nameof(origins));
            }

            Origins = origins.ToList();
            OriginGroups = new ChangeTrackingList<DeepCreatedOriginGroup>();
            CustomDomains = new ChangeTrackingList<CdnCustomDomainData>();
        }

        /// <summary> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </summary>
        public string HostName { get; }
        /// <summary> The source of the content being delivered via CDN. </summary>
        public IReadOnlyList<DeepCreatedOrigin> Origins { get; }
        /// <summary> The origin groups comprising of origins that are used for load balancing the traffic based on availability. </summary>
        public IReadOnlyList<DeepCreatedOriginGroup> OriginGroups { get; }
        /// <summary> The custom domains under the endpoint. </summary>
        public IReadOnlyList<CdnCustomDomainData> CustomDomains { get; }
        /// <summary> Resource status of the endpoint. </summary>
        public EndpointResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the endpoint. </summary>
        public EndpointProvisioningState? ProvisioningState { get; }
    }
}
