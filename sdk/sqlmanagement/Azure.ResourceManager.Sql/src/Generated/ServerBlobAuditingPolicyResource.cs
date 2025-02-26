// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ServerBlobAuditingPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServerBlobAuditingPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServerBlobAuditingPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource" /> using the GetServerBlobAuditingPolicy method.
    /// </summary>
    public partial class ServerBlobAuditingPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerBlobAuditingPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string blobAuditingPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverBlobAuditingPolicyClientDiagnostics;
        private readonly ServerBlobAuditingPoliciesRestOperations _serverBlobAuditingPolicyRestClient;
        private readonly ServerBlobAuditingPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicyResource"/> class for mocking. </summary>
        protected ServerBlobAuditingPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerBlobAuditingPolicyResource(ArmClient client, ServerBlobAuditingPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerBlobAuditingPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverBlobAuditingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serverBlobAuditingPolicyApiVersion);
            _serverBlobAuditingPolicyRestClient = new ServerBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverBlobAuditingPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/auditingSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServerBlobAuditingPolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerBlobAuditingPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerBlobAuditingPolicyResource>> UpdateAsync(WaitUntil waitUntil, ServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerBlobAuditingPolicyResource>(new ServerBlobAuditingPolicyOperationSource(Client), _serverBlobAuditingPolicyClientDiagnostics, Pipeline, _serverBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerBlobAuditingPolicyResource> Update(WaitUntil waitUntil, ServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ServerBlobAuditingPolicyResource>(new ServerBlobAuditingPolicyOperationSource(Client), _serverBlobAuditingPolicyClientDiagnostics, Pipeline, _serverBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
