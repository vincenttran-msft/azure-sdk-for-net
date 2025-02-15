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
using Azure.ResourceManager.DevCenter.Models;

namespace Azure.ResourceManager.DevCenter
{
    public partial class Sample_CatalogResource
    {
        // Catalogs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CatalogsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Catalogs_Get.json
            // this example is just showing the usage of "Catalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CatalogResource created on azure
            // for more information of creating CatalogResource, please refer to the document of CatalogResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            string catalogName = "{catalogName}";
            ResourceIdentifier catalogResourceId = CatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName, catalogName);
            CatalogResource catalog = client.GetCatalogResource(catalogResourceId);

            // invoke the operation
            CatalogResource result = await catalog.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Catalogs_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CatalogsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Catalogs_Patch.json
            // this example is just showing the usage of "Catalogs_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CatalogResource created on azure
            // for more information of creating CatalogResource, please refer to the document of CatalogResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            string catalogName = "{catalogName}";
            ResourceIdentifier catalogResourceId = CatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName, catalogName);
            CatalogResource catalog = client.GetCatalogResource(catalogResourceId);

            // invoke the operation
            CatalogPatch patch = new CatalogPatch()
            {
                GitHub = new GitCatalog()
                {
                    Path = "/environments",
                },
            };
            ArmOperation<CatalogResource> lro = await catalog.UpdateAsync(WaitUntil.Completed, patch);
            CatalogResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Catalogs_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CatalogsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Catalogs_Delete.json
            // this example is just showing the usage of "Catalogs_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CatalogResource created on azure
            // for more information of creating CatalogResource, please refer to the document of CatalogResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            string catalogName = "{catalogName}";
            ResourceIdentifier catalogResourceId = CatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName, catalogName);
            CatalogResource catalog = client.GetCatalogResource(catalogResourceId);

            // invoke the operation
            await catalog.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Catalogs_Sync
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Sync_CatalogsSync()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/Catalogs_Sync.json
            // this example is just showing the usage of "Catalogs_Sync" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CatalogResource created on azure
            // for more information of creating CatalogResource, please refer to the document of CatalogResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            string catalogName = "{catalogName}";
            ResourceIdentifier catalogResourceId = CatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName, catalogName);
            CatalogResource catalog = client.GetCatalogResource(catalogResourceId);

            // invoke the operation
            await catalog.SyncAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
