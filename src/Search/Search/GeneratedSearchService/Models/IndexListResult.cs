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
    /// Response from a List Indexes request. If successful, it includes the
    /// full definitions of all indexes.
    /// </summary>
    public partial class IndexListResult
    {
        /// <summary>
        /// Initializes a new instance of the IndexListResult class.
        /// </summary>
        public IndexListResult() { }

        /// <summary>
        /// Initializes a new instance of the IndexListResult class.
        /// </summary>
        public IndexListResult(IList<Index> value = default(IList<Index>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets the indexes in the Search service.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Index> Value { get; private set; }

    }
}
