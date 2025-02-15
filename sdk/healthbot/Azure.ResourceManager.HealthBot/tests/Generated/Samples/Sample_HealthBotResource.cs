// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthBot.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthBot
{
    public partial class Sample_HealthBotResource
    {
        // ResourceInfoGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ResourceInfoGet()
        {
            // Generated from example definition: specification/healthbot/resource-manager/Microsoft.HealthBot/stable/2021-08-24/examples/ResourceInfoGet.json
            // this example is just showing the usage of "Bots_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthBotResource created on azure
            // for more information of creating HealthBotResource, please refer to the document of HealthBotResource
            string subscriptionId = "subid";
            string resourceGroupName = "healthbotClient";
            string botName = "samplebotname";
            ResourceIdentifier healthBotResourceId = HealthBotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, botName);
            HealthBotResource healthBot = client.GetHealthBotResource(healthBotResourceId);

            // invoke the operation
            HealthBotResource result = await healthBot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthBotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BotUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_BotUpdate()
        {
            // Generated from example definition: specification/healthbot/resource-manager/Microsoft.HealthBot/stable/2021-08-24/examples/ResourceUpdatePatch.json
            // this example is just showing the usage of "Bots_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthBotResource created on azure
            // for more information of creating HealthBotResource, please refer to the document of HealthBotResource
            string subscriptionId = "subid";
            string resourceGroupName = "healthbotClient";
            string botName = "samplebotname";
            ResourceIdentifier healthBotResourceId = HealthBotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, botName);
            HealthBotResource healthBot = client.GetHealthBotResource(healthBotResourceId);

            // invoke the operation
            HealthBotPatch patch = new HealthBotPatch()
            {
                SkuName = HealthBotSkuName.F0,
            };
            HealthBotResource result = await healthBot.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthBotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BotDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BotDelete()
        {
            // Generated from example definition: specification/healthbot/resource-manager/Microsoft.HealthBot/stable/2021-08-24/examples/ResourceDeletionDelete.json
            // this example is just showing the usage of "Bots_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthBotResource created on azure
            // for more information of creating HealthBotResource, please refer to the document of HealthBotResource
            string subscriptionId = "subid";
            string resourceGroupName = "healthbotClient";
            string botName = "samplebotname";
            ResourceIdentifier healthBotResourceId = HealthBotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, botName);
            HealthBotResource healthBot = client.GetHealthBotResource(healthBotResourceId);

            // invoke the operation
            await healthBot.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List Bots by Subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetHealthBots_ListBotsBySubscription()
        {
            // Generated from example definition: specification/healthbot/resource-manager/Microsoft.HealthBot/stable/2021-08-24/examples/ListBotsBySubscription.json
            // this example is just showing the usage of "Bots_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscription-id";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (HealthBotResource item in subscriptionResource.GetHealthBotsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthBotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
