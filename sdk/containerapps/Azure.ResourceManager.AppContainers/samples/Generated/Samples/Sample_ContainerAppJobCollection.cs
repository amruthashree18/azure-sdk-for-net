// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppJobCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Job_CreateorUpdate.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation
            string jobName = "testcontainerappsjob0";
            ContainerAppJobData data = new ContainerAppJobData(new AzureLocation("East US"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned,UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myidentity")] = new UserAssignedIdentity()
},
                },
                EnvironmentId = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/rg/providers/Microsoft.App/managedEnvironments/demokube",
                Configuration = new ContainerAppJobConfiguration(ContainerAppJobTriggerType.Manual, 10)
                {
                    ReplicaRetryLimit = 10,
                    ManualTriggerConfig = new JobConfigurationManualTriggerConfig
                    {
                        ReplicaCompletionCount = 1,
                        Parallelism = 4,
                    },
                    IdentitySettings = {new ContainerAppIdentitySettings("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myidentity")
{
Lifecycle = ContainerAppIdentitySettingsLifeCycle.All,
}, new ContainerAppIdentitySettings("system")
{
Lifecycle = ContainerAppIdentitySettingsLifeCycle.Init,
}},
                },
                Template = new ContainerAppJobTemplate
                {
                    InitContainers = {new ContainerAppInitContainer
{
Image = "repo/testcontainerappsjob0:v4",
Name = "testinitcontainerAppsJob0",
Command = {"/bin/sh"},
Args = {"-c", "while true; do echo hello; sleep 10;done"},
Resources = new AppContainerResources
{
Cpu = 0.5,
Memory = "1Gi",
},
}},
                    Containers = {new ContainerAppContainer
{
Probes = {new ContainerAppProbe
{
HttpGet = new ContainerAppHttpRequestInfo(8080)
{
HttpHeaders = {new ContainerAppHttpHeaderInfo("Custom-Header", "Awesome")},
Path = "/health",
},
InitialDelaySeconds = 5,
PeriodSeconds = 3,
ProbeType = ContainerAppProbeType.Liveness,
}},
Image = "repo/testcontainerappsjob0:v1",
Name = "testcontainerappsjob0",
VolumeMounts = {new ContainerAppVolumeMount
{
VolumeName = "azurefile",
MountPath = "/mnt/path1",
SubPath = "subPath1",
}, new ContainerAppVolumeMount
{
VolumeName = "nfsazurefile",
MountPath = "/mnt/path2",
SubPath = "subPath2",
}},
}},
                    Volumes = {new ContainerAppVolume
{
Name = "azurefile",
StorageType = ContainerAppStorageType.AzureFile,
StorageName = "storage",
}, new ContainerAppVolume
{
Name = "nfsazurefile",
StorageType = ContainerAppStorageType.NfsAzureFile,
StorageName = "nfsStorage",
}},
                },
            };
            ArmOperation<ContainerAppJobResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, jobName, data);
            ContainerAppJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateContainerAppsJobWithEventDrivenTrigger()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Job_CreateorUpdate_EventTrigger.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation
            string jobName = "testcontainerappsjob0";
            ContainerAppJobData data = new ContainerAppJobData(new AzureLocation("East US"))
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myidentity")] = new UserAssignedIdentity()
},
                },
                EnvironmentId = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/rg/providers/Microsoft.App/managedEnvironments/demokube",
                Configuration = new ContainerAppJobConfiguration(ContainerAppJobTriggerType.Event, 10)
                {
                    ReplicaRetryLimit = 10,
                    EventTriggerConfig = new EventTriggerConfiguration
                    {
                        ReplicaCompletionCount = 1,
                        Parallelism = 4,
                        Scale = new ContainerAppJobScale
                        {
                            PollingIntervalInSeconds = 40,
                            MinExecutions = 1,
                            MaxExecutions = 5,
                            Rules = {new ContainerAppJobScaleRule
{
Name = "servicebuscalingrule",
JobScaleRuleType = "azure-servicebus",
Metadata = BinaryData.FromObjectAsJson(new
{
topicName = "my-topic",
}),
Identity = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myidentity",
}},
                        },
                    },
                },
                Template = new ContainerAppJobTemplate
                {
                    InitContainers = {new ContainerAppInitContainer
{
Image = "repo/testcontainerappsjob0:v4",
Name = "testinitcontainerAppsJob0",
Command = {"/bin/sh"},
Args = {"-c", "while true; do echo hello; sleep 10;done"},
Resources = new AppContainerResources
{
Cpu = 0.5,
Memory = "1Gi",
},
}},
                    Containers = {new ContainerAppContainer
{
Image = "repo/testcontainerappsjob0:v1",
Name = "testcontainerappsjob0",
}},
                },
            };
            ArmOperation<ContainerAppJobResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, jobName, data);
            ContainerAppJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Job_Get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation
            string jobName = "testcontainerappsjob0";
            ContainerAppJobResource result = await collection.GetAsync(jobName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListContainerAppsJobsByResourceGroup()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Jobs_ListByResourceGroup.json
            // this example is just showing the usage of "Jobs_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppJobResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Job_Get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation
            string jobName = "testcontainerappsjob0";
            bool result = await collection.ExistsAsync(jobName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/Job_Get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppJobResource
            ContainerAppJobCollection collection = resourceGroupResource.GetContainerAppJobs();

            // invoke the operation
            string jobName = "testcontainerappsjob0";
            NullableResponse<ContainerAppJobResource> response = await collection.GetIfExistsAsync(jobName);
            ContainerAppJobResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppJobData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
