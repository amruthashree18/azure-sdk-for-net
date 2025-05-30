// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ScopeMapResource"/> and their operations.
    /// Each <see cref="ScopeMapResource"/> in the collection will belong to the same instance of <see cref="ContainerRegistryResource"/>.
    /// To get a <see cref="ScopeMapCollection"/> instance call the GetScopeMaps method from an instance of <see cref="ContainerRegistryResource"/>.
    /// </summary>
    public partial class ScopeMapCollection : ArmCollection, IEnumerable<ScopeMapResource>, IAsyncEnumerable<ScopeMapResource>
    {
        private readonly ClientDiagnostics _scopeMapClientDiagnostics;
        private readonly ScopeMapsRestOperations _scopeMapRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScopeMapCollection"/> class for mocking. </summary>
        protected ScopeMapCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScopeMapCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScopeMapCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scopeMapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ScopeMapResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScopeMapResource.ResourceType, out string scopeMapApiVersion);
            _scopeMapRestClient = new ScopeMapsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scopeMapApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a scope map for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="data"> The parameters for creating a scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScopeMapResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scopeMapName, ScopeMapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scopeMapRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ScopeMapResource>(new ScopeMapOperationSource(Client), _scopeMapClientDiagnostics, Pipeline, _scopeMapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a scope map for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="data"> The parameters for creating a scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScopeMapResource> CreateOrUpdate(WaitUntil waitUntil, string scopeMapName, ScopeMapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scopeMapRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ScopeMapResource>(new ScopeMapOperationSource(Client), _scopeMapClientDiagnostics, Pipeline, _scopeMapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets the properties of the specified scope map.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual async Task<Response<ScopeMapResource>> GetAsync(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.Get");
            scope.Start();
            try
            {
                var response = await _scopeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified scope map.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual Response<ScopeMapResource> Get(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.Get");
            scope.Start();
            try
            {
                var response = _scopeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the scope maps for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScopeMapResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScopeMapResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeMapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeMapRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScopeMapResource(Client, ScopeMapData.DeserializeScopeMapData(e)), _scopeMapClientDiagnostics, Pipeline, "ScopeMapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the scope maps for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScopeMapResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScopeMapResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeMapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeMapRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScopeMapResource(Client, ScopeMapData.DeserializeScopeMapData(e)), _scopeMapClientDiagnostics, Pipeline, "ScopeMapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scopeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual Response<bool> Exists(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.Exists");
            scope.Start();
            try
            {
                var response = _scopeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScopeMapResource>> GetIfExistsAsync(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scopeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScopeMapResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/scopeMaps/{scopeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeMaps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeMapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeMapName"> The name of the scope map. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeMapName"/> is null. </exception>
        public virtual NullableResponse<ScopeMapResource> GetIfExists(string scopeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeMapName, nameof(scopeMapName));

            using var scope = _scopeMapClientDiagnostics.CreateScope("ScopeMapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scopeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeMapName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScopeMapResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScopeMapResource> IEnumerable<ScopeMapResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScopeMapResource> IAsyncEnumerable<ScopeMapResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
