// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Dynatrace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single sign-on configurations for a given monitor resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DynatraceSingleSignOnResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DynatraceSingleSignOnResource
        /// class.
        /// </summary>
        public DynatraceSingleSignOnResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynatraceSingleSignOnResource
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="singleSignOnState">State of Single Sign On. Possible
        /// values include: 'Initial', 'Enable', 'Disable', 'Existing'</param>
        /// <param name="enterpriseAppId">Version of the Dynatrace agent
        /// installed on the VM.</param>
        /// <param name="singleSignOnUrl">The login URL specific to this
        /// Dynatrace Environment</param>
        /// <param name="aadDomains">array of Aad(azure active directory)
        /// domains</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Accepted', 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Canceled', 'Deleted',
        /// 'NotSpecified'</param>
        /// <param name="systemData">System metadata for this resource.</param>
        public DynatraceSingleSignOnResource(string id = default(string), string name = default(string), string type = default(string), string singleSignOnState = default(string), string enterpriseAppId = default(string), string singleSignOnUrl = default(string), IList<string> aadDomains = default(IList<string>), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUrl = singleSignOnUrl;
            AadDomains = aadDomains;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets state of Single Sign On. Possible values include:
        /// 'Initial', 'Enable', 'Disable', 'Existing'
        /// </summary>
        [JsonProperty(PropertyName = "properties.singleSignOnState")]
        public string SingleSignOnState { get; set; }

        /// <summary>
        /// Gets or sets version of the Dynatrace agent installed on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enterpriseAppId")]
        public string EnterpriseAppId { get; set; }

        /// <summary>
        /// Gets or sets the login URL specific to this Dynatrace Environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.singleSignOnUrl")]
        public string SingleSignOnUrl { get; set; }

        /// <summary>
        /// Gets or sets array of Aad(azure active directory) domains
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadDomains")]
        public IList<string> AadDomains { get; set; }

        /// <summary>
        /// Gets provisioning state of the resource. Possible values include:
        /// 'Accepted', 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleted', 'NotSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets system metadata for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
