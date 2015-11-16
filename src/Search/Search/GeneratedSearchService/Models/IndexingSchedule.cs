// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents a schedule for indexer execution.
    /// </summary>
    public partial class IndexingSchedule
    {
        /// <summary>
        /// Initializes a new instance of the IndexingSchedule class.
        /// </summary>
        public IndexingSchedule() { }

        /// <summary>
        /// Initializes a new instance of the IndexingSchedule class.
        /// </summary>
        public IndexingSchedule(TimeSpan? interval, DateTime? startTime = default(DateTime?))
        {
            Interval = interval;
            StartTime = startTime;
        }

        /// <summary>
        /// Gets or sets the interval of time between indexer executions.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public TimeSpan? Interval { get; set; }

        /// <summary>
        /// Gets or sets the time when an indexer should start running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Interval == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Interval");
            }
        }
    }
}
