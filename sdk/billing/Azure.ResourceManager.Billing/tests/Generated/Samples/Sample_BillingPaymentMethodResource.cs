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

namespace Azure.ResourceManager.Billing
{
    public partial class Sample_BillingPaymentMethodResource
    {
        // GetPaymentMethodOwnedByUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPaymentMethodOwnedByUser()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2021-10-01/examples/PaymentMethodOwnedByUser_Get.json
            // this example is just showing the usage of "PaymentMethods_GetByUser" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this BillingPaymentMethodResource created on azure
            // for more information of creating BillingPaymentMethodResource, please refer to the document of BillingPaymentMethodResource
            string paymentMethodName = "ABCDABCDABC0";
            ResourceIdentifier billingPaymentMethodResourceId = BillingPaymentMethodResource.CreateResourceIdentifier(paymentMethodName);
            BillingPaymentMethodResource billingPaymentMethod = client.GetBillingPaymentMethodResource(billingPaymentMethodResourceId);

            // invoke the operation
            BillingPaymentMethodResource result = await billingPaymentMethod.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPaymentMethodData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeletePaymentMethodOwnedByUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePaymentMethodOwnedByUser()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2021-10-01/examples/PaymentMethodOwnedByUser_Delete.json
            // this example is just showing the usage of "PaymentMethods_DeleteByUser" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this BillingPaymentMethodResource created on azure
            // for more information of creating BillingPaymentMethodResource, please refer to the document of BillingPaymentMethodResource
            string paymentMethodName = "ABCDABCDABC0";
            ResourceIdentifier billingPaymentMethodResourceId = BillingPaymentMethodResource.CreateResourceIdentifier(paymentMethodName);
            BillingPaymentMethodResource billingPaymentMethod = client.GetBillingPaymentMethodResource(billingPaymentMethodResourceId);

            // invoke the operation
            await billingPaymentMethod.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
