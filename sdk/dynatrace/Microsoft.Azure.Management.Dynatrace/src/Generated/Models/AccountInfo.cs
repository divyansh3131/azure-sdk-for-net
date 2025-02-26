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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dynatrace Account Information
    /// </summary>
    public partial class AccountInfo
    {
        /// <summary>
        /// Initializes a new instance of the AccountInfo class.
        /// </summary>
        public AccountInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountInfo class.
        /// </summary>
        /// <param name="accountId">Account Id of the account this environment
        /// is linked to</param>
        /// <param name="regionId">Region in which the account is
        /// created</param>
        public AccountInfo(string accountId = default(string), string regionId = default(string))
        {
            AccountId = accountId;
            RegionId = regionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account Id of the account this environment is linked
        /// to
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets region in which the account is created
        /// </summary>
        [JsonProperty(PropertyName = "regionId")]
        public string RegionId { get; set; }

    }
}
