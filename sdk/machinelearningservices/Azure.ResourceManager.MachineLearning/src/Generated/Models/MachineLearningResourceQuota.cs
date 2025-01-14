// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The quota assigned to a resource. </summary>
    public partial class MachineLearningResourceQuota
    {
        /// <summary> Initializes a new instance of MachineLearningResourceQuota. </summary>
        internal MachineLearningResourceQuota()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningResourceQuota. </summary>
        /// <param name="id"> Specifies the resource ID. </param>
        /// <param name="amlWorkspaceLocation"> Region of the AML workspace in the id. </param>
        /// <param name="resourceQuotaType"> Specifies the resource type. </param>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="limit"> The maximum permitted quota of the resource. </param>
        /// <param name="unit"> An enum describing the unit of quota measurement. </param>
        internal MachineLearningResourceQuota(string id, string amlWorkspaceLocation, string resourceQuotaType, MachineLearningResourceName name, long? limit, MachineLearningQuotaUnit? unit)
        {
            Id = id;
            AmlWorkspaceLocation = amlWorkspaceLocation;
            ResourceQuotaType = resourceQuotaType;
            Name = name;
            Limit = limit;
            Unit = unit;
        }

        /// <summary> Specifies the resource ID. </summary>
        public string Id { get; }
        /// <summary> Region of the AML workspace in the id. </summary>
        public string AmlWorkspaceLocation { get; }
        /// <summary> Specifies the resource type. </summary>
        public string ResourceQuotaType { get; }
        /// <summary> Name of the resource. </summary>
        public MachineLearningResourceName Name { get; }
        /// <summary> The maximum permitted quota of the resource. </summary>
        public long? Limit { get; }
        /// <summary> An enum describing the unit of quota measurement. </summary>
        public MachineLearningQuotaUnit? Unit { get; }
    }
}
