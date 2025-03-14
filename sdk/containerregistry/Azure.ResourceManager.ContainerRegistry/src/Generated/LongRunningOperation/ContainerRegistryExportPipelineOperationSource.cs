// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryExportPipelineOperationSource : IOperationSource<ContainerRegistryExportPipelineResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryExportPipelineOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryExportPipelineResource IOperationSource<ContainerRegistryExportPipelineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerRegistryExportPipelineData>(response.Content);
            return new ContainerRegistryExportPipelineResource(_client, data);
        }

        async ValueTask<ContainerRegistryExportPipelineResource> IOperationSource<ContainerRegistryExportPipelineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerRegistryExportPipelineData>(response.Content);
            return await Task.FromResult(new ContainerRegistryExportPipelineResource(_client, data)).ConfigureAwait(false);
        }
    }
}
