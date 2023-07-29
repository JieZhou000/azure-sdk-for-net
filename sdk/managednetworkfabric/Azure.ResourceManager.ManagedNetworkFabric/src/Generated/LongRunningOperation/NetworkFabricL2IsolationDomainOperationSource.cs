// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricL2IsolationDomainOperationSource : IOperationSource<NetworkFabricL2IsolationDomainResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricL2IsolationDomainOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricL2IsolationDomainResource IOperationSource<NetworkFabricL2IsolationDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricL2IsolationDomainData.DeserializeNetworkFabricL2IsolationDomainData(document.RootElement);
            return new NetworkFabricL2IsolationDomainResource(_client, data);
        }

        async ValueTask<NetworkFabricL2IsolationDomainResource> IOperationSource<NetworkFabricL2IsolationDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricL2IsolationDomainData.DeserializeNetworkFabricL2IsolationDomainData(document.RootElement);
            return new NetworkFabricL2IsolationDomainResource(_client, data);
        }
    }
}
