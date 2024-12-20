// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_JitNetworkAccessPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetJitNetworkAccessPolicies_GetJITNetworkAccessPoliciesOnASubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPoliciesSubscription_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (JitNetworkAccessPolicyResource item in subscriptionResource.GetJitNetworkAccessPoliciesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JitNetworkAccessPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetJitNetworkAccessPolicies_GetJITNetworkAccessPoliciesOnAResourceGroup()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPoliciesResourceGroup_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (JitNetworkAccessPolicyResource item in resourceGroupResource.GetJitNetworkAccessPoliciesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JitNetworkAccessPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this JitNetworkAccessPolicyResource created on azure
            // for more information of creating JitNetworkAccessPolicyResource, please refer to the document of JitNetworkAccessPolicyResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string jitNetworkAccessPolicyName = "default";
            ResourceIdentifier jitNetworkAccessPolicyResourceId = JitNetworkAccessPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ascLocation, jitNetworkAccessPolicyName);
            JitNetworkAccessPolicyResource jitNetworkAccessPolicy = client.GetJitNetworkAccessPolicyResource(jitNetworkAccessPolicyResourceId);

            // invoke the operation
            JitNetworkAccessPolicyResource result = await jitNetworkAccessPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JitNetworkAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/CreateJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this JitNetworkAccessPolicyResource created on azure
            // for more information of creating JitNetworkAccessPolicyResource, please refer to the document of JitNetworkAccessPolicyResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string jitNetworkAccessPolicyName = "default";
            ResourceIdentifier jitNetworkAccessPolicyResourceId = JitNetworkAccessPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ascLocation, jitNetworkAccessPolicyName);
            JitNetworkAccessPolicyResource jitNetworkAccessPolicy = client.GetJitNetworkAccessPolicyResource(jitNetworkAccessPolicyResourceId);

            // invoke the operation
            JitNetworkAccessPolicyData data = new JitNetworkAccessPolicyData(new JitNetworkAccessPolicyVirtualMachine[]
            {
new JitNetworkAccessPolicyVirtualMachine(new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg1/providers/Microsoft.Compute/virtualMachines/vm1"),new JitNetworkAccessPortRule[]
{
new JitNetworkAccessPortRule(22,JitNetworkAccessPortProtocol.All,XmlConvert.ToTimeSpan("PT3H"))
{
AllowedSourceAddressPrefix = "*",
},new JitNetworkAccessPortRule(3389,JitNetworkAccessPortProtocol.All,XmlConvert.ToTimeSpan("PT3H"))
{
AllowedSourceAddressPrefix = "*",
}
})
            })
            {
                Requests =
{
new JitNetworkAccessRequestInfo(new JitNetworkAccessRequestVirtualMachine[]
{
new JitNetworkAccessRequestVirtualMachine(new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg1/providers/Microsoft.Compute/virtualMachines/vm1"),new JitNetworkAccessRequestPort[]
{
new JitNetworkAccessRequestPort(3389,DateTimeOffset.Parse("2018-05-17T09:06:45.5691611Z"),JitNetworkAccessPortStatus.Initiated,JitNetworkAccessPortStatusReason.UserRequested)
{
AllowedSourceAddressPrefix = "192.127.0.2",
}
})
},DateTimeOffset.Parse("2018-05-17T08:06:45.5691611Z"),"barbara@contoso.com")
},
                Kind = "Basic",
            };
            ArmOperation<JitNetworkAccessPolicyResource> lro = await jitNetworkAccessPolicy.UpdateAsync(WaitUntil.Completed, data);
            JitNetworkAccessPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JitNetworkAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/DeleteJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this JitNetworkAccessPolicyResource created on azure
            // for more information of creating JitNetworkAccessPolicyResource, please refer to the document of JitNetworkAccessPolicyResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string jitNetworkAccessPolicyName = "default";
            ResourceIdentifier jitNetworkAccessPolicyResourceId = JitNetworkAccessPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ascLocation, jitNetworkAccessPolicyName);
            JitNetworkAccessPolicyResource jitNetworkAccessPolicy = client.GetJitNetworkAccessPolicyResource(jitNetworkAccessPolicyResourceId);

            // invoke the operation
            await jitNetworkAccessPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Initiate_InitiateAnActionOnAJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/InitiateJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Initiate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this JitNetworkAccessPolicyResource created on azure
            // for more information of creating JitNetworkAccessPolicyResource, please refer to the document of JitNetworkAccessPolicyResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string jitNetworkAccessPolicyName = "default";
            ResourceIdentifier jitNetworkAccessPolicyResourceId = JitNetworkAccessPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ascLocation, jitNetworkAccessPolicyName);
            JitNetworkAccessPolicyResource jitNetworkAccessPolicy = client.GetJitNetworkAccessPolicyResource(jitNetworkAccessPolicyResourceId);

            // invoke the operation
            JitNetworkAccessPolicyInitiateContent content = new JitNetworkAccessPolicyInitiateContent(new JitNetworkAccessPolicyInitiateVirtualMachine[]
            {
new JitNetworkAccessPolicyInitiateVirtualMachine(new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg1/providers/Microsoft.Compute/virtualMachines/vm1"),new JitNetworkAccessPolicyInitiatePort[]
{
new JitNetworkAccessPolicyInitiatePort(3389,DateTimeOffset.Parse("placeholder"))
{
AllowedSourceAddressPrefix = "192.127.0.2",
}
})
            })
            {
                Justification = "testing a new version of the product",
            };
            JitNetworkAccessRequestInfo result = await jitNetworkAccessPolicy.InitiateAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
