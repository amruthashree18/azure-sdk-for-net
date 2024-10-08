// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="HciEdgeDeviceResource"/> and their operations.
    /// Each <see cref="HciEdgeDeviceResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="HciEdgeDeviceCollection"/> instance call the GetHciEdgeDevices method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class HciEdgeDeviceCollection : ArmCollection, IEnumerable<HciEdgeDeviceResource>, IAsyncEnumerable<HciEdgeDeviceResource>
    {
        private readonly ClientDiagnostics _hciEdgeDeviceEdgeDevicesClientDiagnostics;
        private readonly EdgeDevicesRestOperations _hciEdgeDeviceEdgeDevicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HciEdgeDeviceCollection"/> class for mocking. </summary>
        protected HciEdgeDeviceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciEdgeDeviceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HciEdgeDeviceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciEdgeDeviceEdgeDevicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", HciEdgeDeviceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HciEdgeDeviceResource.ResourceType, out string hciEdgeDeviceEdgeDevicesApiVersion);
            _hciEdgeDeviceEdgeDevicesRestClient = new EdgeDevicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciEdgeDeviceEdgeDevicesApiVersion);
        }

        /// <summary>
        /// Create a EdgeDevice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HciEdgeDeviceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string edgeDeviceName, HciEdgeDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hciEdgeDeviceEdgeDevicesRestClient.CreateOrUpdateAsync(Id, edgeDeviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<HciEdgeDeviceResource>(new HciEdgeDeviceOperationSource(Client), _hciEdgeDeviceEdgeDevicesClientDiagnostics, Pipeline, _hciEdgeDeviceEdgeDevicesRestClient.CreateCreateOrUpdateRequest(Id, edgeDeviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a EdgeDevice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HciEdgeDeviceResource> CreateOrUpdate(WaitUntil waitUntil, string edgeDeviceName, HciEdgeDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hciEdgeDeviceEdgeDevicesRestClient.CreateOrUpdate(Id, edgeDeviceName, data, cancellationToken);
                var operation = new HciArmOperation<HciEdgeDeviceResource>(new HciEdgeDeviceOperationSource(Client), _hciEdgeDeviceEdgeDevicesClientDiagnostics, Pipeline, _hciEdgeDeviceEdgeDevicesRestClient.CreateCreateOrUpdateRequest(Id, edgeDeviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a EdgeDevice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual async Task<Response<HciEdgeDeviceResource>> GetAsync(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = await _hciEdgeDeviceEdgeDevicesRestClient.GetAsync(Id, edgeDeviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a EdgeDevice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual Response<HciEdgeDeviceResource> Get(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = _hciEdgeDeviceEdgeDevicesRestClient.Get(Id, edgeDeviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List EdgeDevice resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciEdgeDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciEdgeDeviceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciEdgeDeviceEdgeDevicesRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciEdgeDeviceEdgeDevicesRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciEdgeDeviceResource(Client, HciEdgeDeviceData.DeserializeHciEdgeDeviceData(e)), _hciEdgeDeviceEdgeDevicesClientDiagnostics, Pipeline, "HciEdgeDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List EdgeDevice resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciEdgeDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciEdgeDeviceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciEdgeDeviceEdgeDevicesRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciEdgeDeviceEdgeDevicesRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciEdgeDeviceResource(Client, HciEdgeDeviceData.DeserializeHciEdgeDeviceData(e)), _hciEdgeDeviceEdgeDevicesClientDiagnostics, Pipeline, "HciEdgeDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hciEdgeDeviceEdgeDevicesRestClient.GetAsync(Id, edgeDeviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = _hciEdgeDeviceEdgeDevicesRestClient.Get(Id, edgeDeviceName, cancellationToken: cancellationToken);
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
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual async Task<NullableResponse<HciEdgeDeviceResource>> GetIfExistsAsync(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hciEdgeDeviceEdgeDevicesRestClient.GetAsync(Id, edgeDeviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HciEdgeDeviceResource>(response.GetRawResponse());
                return Response.FromValue(new HciEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceUri}/providers/Microsoft.AzureStackHCI/edgeDevices/{edgeDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EdgeDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="edgeDeviceName"> Name of Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="edgeDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeDeviceName"/> is null. </exception>
        public virtual NullableResponse<HciEdgeDeviceResource> GetIfExists(string edgeDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(edgeDeviceName, nameof(edgeDeviceName));

            using var scope = _hciEdgeDeviceEdgeDevicesClientDiagnostics.CreateScope("HciEdgeDeviceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hciEdgeDeviceEdgeDevicesRestClient.Get(Id, edgeDeviceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HciEdgeDeviceResource>(response.GetRawResponse());
                return Response.FromValue(new HciEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HciEdgeDeviceResource> IEnumerable<HciEdgeDeviceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HciEdgeDeviceResource> IAsyncEnumerable<HciEdgeDeviceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
