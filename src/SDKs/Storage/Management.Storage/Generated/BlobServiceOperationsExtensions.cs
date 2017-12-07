// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BlobServiceOperations.
    /// </summary>
    public static partial class BlobServiceOperationsExtensions
    {
            /// <summary>
            /// Sets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cors'>
            /// Specifies a CORS rule for the Blob service. You can include up to five
            /// CorsRule elements in the request. If no CorsRule elements are included in
            /// the request body, all CORS rules will be deleted, and CORS will be disabled
            /// for the Blob service.
            /// </param>
            /// <param name='defaultServiceVersion'>
            /// DefaultServiceVersion indicates the default version to use for requests to
            /// the Blob service if an incoming request’s version is not specified.
            /// Possible values include version 2008-10-27 and all more recent versions.
            /// </param>
            public static void SetServiceProperties(this IBlobServiceOperations operations, string resourceGroupName, string accountName, CorsRule cors = default(CorsRule), string defaultServiceVersion = default(string))
            {
                operations.SetServicePropertiesAsync(resourceGroupName, accountName, cors, defaultServiceVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cors'>
            /// Specifies a CORS rule for the Blob service. You can include up to five
            /// CorsRule elements in the request. If no CorsRule elements are included in
            /// the request body, all CORS rules will be deleted, and CORS will be disabled
            /// for the Blob service.
            /// </param>
            /// <param name='defaultServiceVersion'>
            /// DefaultServiceVersion indicates the default version to use for requests to
            /// the Blob service if an incoming request’s version is not specified.
            /// Possible values include version 2008-10-27 and all more recent versions.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetServicePropertiesAsync(this IBlobServiceOperations operations, string resourceGroupName, string accountName, CorsRule cors = default(CorsRule), string defaultServiceVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetServicePropertiesWithHttpMessagesAsync(resourceGroupName, accountName, cors, defaultServiceVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static BlobServiceProperties GetServiceProperties(this IBlobServiceOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetServicePropertiesAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BlobServiceProperties> GetServicePropertiesAsync(this IBlobServiceOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetServicePropertiesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
