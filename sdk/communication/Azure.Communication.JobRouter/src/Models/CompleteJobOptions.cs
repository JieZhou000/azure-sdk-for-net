﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Options for completing a job.
    /// </summary>
    public partial class CompleteJobOptions
    {
        /// <summary> Initializes a new instance of CompleteJobOptions. </summary>
        internal CompleteJobOptions()
        {
        }

        /// <param name="jobId"> Id of the job. </param>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is an empty string, and was expected to be non-empty. </exception>

        public CompleteJobOptions(string jobId, string assignmentId)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNullOrEmpty(assignmentId, nameof(assignmentId));

            JobId = jobId;
            AssignmentId = assignmentId;
        }

        /// <summary> Id of the job assignment. </summary>
        public string AssignmentId { get; }

        /// <summary>
        /// Id of the job.
        /// </summary>
        public string JobId { get; }

        /// <summary>
        /// Custom supplied note.
        /// </summary>
        public string Note { get; set; }
    }
}
