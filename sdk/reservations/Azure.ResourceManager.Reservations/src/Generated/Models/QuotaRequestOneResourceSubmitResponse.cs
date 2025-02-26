// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Response for the quota submission request. </summary>
    internal partial class QuotaRequestOneResourceSubmitResponse : ResourceData
    {
        /// <summary> Initializes a new instance of QuotaRequestOneResourceSubmitResponse. </summary>
        internal QuotaRequestOneResourceSubmitResponse()
        {
        }

        /// <summary> The quota request status. </summary>
        public QuotaRequestState? ProvisioningState { get; }
        /// <summary> User friendly status message. </summary>
        public string Message { get; }
        /// <summary> The time when the quota request was submitted using format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? RequestSubmitOn { get; }
        /// <summary> The quota request ID. </summary>
        public string IdPropertiesId { get; }
        /// <summary> The name of the quota request. </summary>
        public string NamePropertiesName { get; }
        /// <summary> Type of resource. &quot;Microsoft.Capacity/ServiceLimits&quot;. </summary>
        public string TypePropertiesType { get; }
        /// <summary> Quota properties for the resource. </summary>
        public QuotaProperties Properties { get; }
    }
}
