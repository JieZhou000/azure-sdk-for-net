// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Action for alert rule. </summary>
    public partial class SecurityInsightsAlertRuleActionCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleActionCreateOrUpdateContent. </summary>
        public SecurityInsightsAlertRuleActionCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleActionCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="logicAppResourceId"> Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}. </param>
        /// <param name="triggerUri"> Logic App Callback URL for this specific workflow. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsAlertRuleActionCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier logicAppResourceId, Uri triggerUri, ETag? etag) : base(id, name, resourceType, systemData)
        {
            LogicAppResourceId = logicAppResourceId;
            TriggerUri = triggerUri;
            ETag = etag;
        }

        /// <summary> Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}. </summary>
        public ResourceIdentifier LogicAppResourceId { get; set; }
        /// <summary> Logic App Callback URL for this specific workflow. </summary>
        public Uri TriggerUri { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
