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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A managed identity assigned by the user.
    /// </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentity class.
        /// </summary>
        public UserAssignedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentity class.
        /// </summary>
        /// <param name="clientId">The active directory client identifier for
        /// this principal.</param>
        /// <param name="principalId">The active directory identifier for this
        /// principal.</param>
        public UserAssignedIdentity(string clientId, string principalId)
        {
            ClientId = clientId;
            PrincipalId = principalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the active directory client identifier for this
        /// principal.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the active directory identifier for this principal.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (PrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrincipalId");
            }
        }
    }
}
