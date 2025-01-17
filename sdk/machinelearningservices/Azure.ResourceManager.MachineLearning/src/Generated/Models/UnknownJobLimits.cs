// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownJobLimits. </summary>
    internal partial class UnknownJobLimits : MachineLearningJobLimits
    {
        /// <summary> Initializes a new instance of UnknownJobLimits. </summary>
        /// <param name="jobLimitsType"> [Required] JobLimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        internal UnknownJobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout) : base(jobLimitsType, timeout)
        {
            JobLimitsType = jobLimitsType;
        }
    }
}
