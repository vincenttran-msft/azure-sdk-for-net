// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    public partial class Sample_SubscriptionAliasCollection
    {
        // CreateAlias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAlias()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/createAlias.json
            // this example is just showing the usage of "Alias_Create" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionAliasResource
            SubscriptionAliasCollection collection = tenantResource.GetSubscriptionAliases();

            // invoke the operation
            string aliasName = "aliasForNewSub";
            SubscriptionAliasCreateOrUpdateContent content = new SubscriptionAliasCreateOrUpdateContent()
            {
                DisplayName = "Test Subscription",
                Workload = SubscriptionWorkload.Production,
                BillingScope = "/billingAccounts/af6231a7-7f8d-4fcc-a993-dd8466108d07:c663dac6-a9a5-405a-8938-cd903e12ab5b_2019_05_31/billingProfiles/QWDQ-QWHI-AUW-SJDO-DJH/invoiceSections/FEUF-EUHE-ISJ-SKDW-DJH",
                SubscriptionId = null,
                AdditionalProperties = new SubscriptionAliasAdditionalProperties()
                {
                    ManagementGroupId = null,
                    SubscriptionTenantId = Guid.Parse("66f6e4d6-07dc-4aea-94ea-e12d3026a3c8"),
                    SubscriptionOwnerId = "f09b39eb-c496-482c-9ab9-afd799572f4c",
                    Tags =
{
["tag1"] = "Messi",
["tag2"] = "Ronaldo",
["tag3"] = "Lebron",
},
                },
            };
            ArmOperation<SubscriptionAliasResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, aliasName, content);
            SubscriptionAliasResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubscriptionAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetAlias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAlias()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/getAlias.json
            // this example is just showing the usage of "Alias_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionAliasResource
            SubscriptionAliasCollection collection = tenantResource.GetSubscriptionAliases();

            // invoke the operation
            string aliasName = "aliasForNewSub";
            SubscriptionAliasResource result = await collection.GetAsync(aliasName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubscriptionAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetAlias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAlias()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/getAlias.json
            // this example is just showing the usage of "Alias_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionAliasResource
            SubscriptionAliasCollection collection = tenantResource.GetSubscriptionAliases();

            // invoke the operation
            string aliasName = "aliasForNewSub";
            bool result = await collection.ExistsAsync(aliasName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ListAlias
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAlias()
        {
            // Generated from example definition: specification/subscription/resource-manager/Microsoft.Subscription/stable/2021-10-01/examples/listAlias.json
            // this example is just showing the usage of "Alias_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionAliasResource
            SubscriptionAliasCollection collection = tenantResource.GetSubscriptionAliases();

            // invoke the operation and iterate over the result
            await foreach (SubscriptionAliasResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SubscriptionAliasData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
