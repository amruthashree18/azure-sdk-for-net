﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.RedisEnterprise.Tests
{
    public class RedisEnterpriseManagementTestBase : ManagementRecordedTestBase<RedisEnterpriseManagementTestEnvironment>
    {
        protected AzureLocation DefaultLocation => "centraluseuap";

        protected ArmClient Client { get; private set; }

        protected SubscriptionResource DefaultSubscription { get; private set; }

        protected RedisEnterpriseManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected RedisEnterpriseManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        protected async Task<ResourceGroupResource> CreateResourceGroupAsync()
        {
            var resourceGroupName = Recording.GenerateAssetName("testRG-");
            var rgOp = await DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(
                WaitUntil.Completed,
                resourceGroupName,
                new ResourceGroupData(DefaultLocation)
                {
                    Tags =
                    {
                        { "test", "env" }
                    }
                });
            return rgOp.Value;
        }
    }
}
