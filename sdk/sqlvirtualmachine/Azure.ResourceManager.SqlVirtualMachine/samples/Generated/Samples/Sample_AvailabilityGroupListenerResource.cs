// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SqlVirtualMachine.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SqlVirtualMachine.Samples
{
    public partial class Sample_AvailabilityGroupListenerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAnAvailabilityGroupListener()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvailabilityGroupListenerResource created on azure
            // for more information of creating AvailabilityGroupListenerResource, please refer to the document of AvailabilityGroupListenerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            string availabilityGroupListenerName = "agl-test";
            ResourceIdentifier availabilityGroupListenerResourceId = AvailabilityGroupListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName, availabilityGroupListenerName);
            AvailabilityGroupListenerResource availabilityGroupListener = client.GetAvailabilityGroupListenerResource(availabilityGroupListenerResourceId);

            // invoke the operation
            AvailabilityGroupListenerResource result = await availabilityGroupListener.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesAnAvailabilityGroupListener()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/DeleteAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvailabilityGroupListenerResource created on azure
            // for more information of creating AvailabilityGroupListenerResource, please refer to the document of AvailabilityGroupListenerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            string availabilityGroupListenerName = "agl-test";
            ResourceIdentifier availabilityGroupListenerResourceId = AvailabilityGroupListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName, availabilityGroupListenerName);
            AvailabilityGroupListenerResource availabilityGroupListener = client.GetAvailabilityGroupListenerResource(availabilityGroupListenerResourceId);

            // invoke the operation
            await availabilityGroupListener.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesOrUpdatesAnAvailabilityGroupListenerUsingLoadBalancerThisIsUsedForVMsPresentInSingleSubnet()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateAvailabilityGroupListener.json
            // this example is just showing the usage of "AvailabilityGroupListeners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvailabilityGroupListenerResource created on azure
            // for more information of creating AvailabilityGroupListenerResource, please refer to the document of AvailabilityGroupListenerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            string availabilityGroupListenerName = "agl-test";
            ResourceIdentifier availabilityGroupListenerResourceId = AvailabilityGroupListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName, availabilityGroupListenerName);
            AvailabilityGroupListenerResource availabilityGroupListener = client.GetAvailabilityGroupListenerResource(availabilityGroupListenerResourceId);

            // invoke the operation
            AvailabilityGroupListenerData data = new AvailabilityGroupListenerData
            {
                AvailabilityGroupName = "ag-test",
                LoadBalancerConfigurations = {new AvailabilityGroupListenerLoadBalancerConfiguration
{
PrivateIPAddress = new AvailabilityGroupListenerPrivateIPAddress
{
IPAddress = IPAddress.Parse("10.1.0.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/default"),
},
LoadBalancerResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/loadBalancers/lb-test"),
ProbePort = 59983,
SqlVmInstances = {new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm2"), new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm3")},
}},
                Port = 1433,
            };
            ArmOperation<AvailabilityGroupListenerResource> lro = await availabilityGroupListener.UpdateAsync(WaitUntil.Completed, data);
            AvailabilityGroupListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesOrUpdatesAnAvailabilityGroupListenerThisIsUsedForVMsPresentInMultiSubnet()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateAvailabilityGroupListenerWithMultiSubnet.json
            // this example is just showing the usage of "AvailabilityGroupListeners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvailabilityGroupListenerResource created on azure
            // for more information of creating AvailabilityGroupListenerResource, please refer to the document of AvailabilityGroupListenerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            string availabilityGroupListenerName = "agl-test";
            ResourceIdentifier availabilityGroupListenerResourceId = AvailabilityGroupListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName, availabilityGroupListenerName);
            AvailabilityGroupListenerResource availabilityGroupListener = client.GetAvailabilityGroupListenerResource(availabilityGroupListenerResourceId);

            // invoke the operation
            AvailabilityGroupListenerData data = new AvailabilityGroupListenerData
            {
                AvailabilityGroupName = "ag-test",
                MultiSubnetIPConfigurations = {new MultiSubnetIPConfiguration(new AvailabilityGroupListenerPrivateIPAddress
{
IPAddress = IPAddress.Parse("10.0.0.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/default"),
}, "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm2"), new MultiSubnetIPConfiguration(new AvailabilityGroupListenerPrivateIPAddress
{
IPAddress = IPAddress.Parse("10.0.1.112"),
SubnetResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/alternate"),
}, "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm1")},
                Port = 1433,
            };
            ArmOperation<AvailabilityGroupListenerResource> lro = await availabilityGroupListener.UpdateAsync(WaitUntil.Completed, data);
            AvailabilityGroupListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvailabilityGroupListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
