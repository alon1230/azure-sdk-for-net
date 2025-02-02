// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The ObservedIntegers. </summary>
    public partial class ObservedIntegers : ObservedValue
    {
        /// <summary> Initializes a new instance of <see cref="ObservedIntegers"/>. </summary>
        internal ObservedIntegers()
        {
            Values = new ChangeTrackingList<int>();
            Sources = new ChangeTrackingList<SourceDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="ObservedIntegers"/>. </summary>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="values"></param>
        /// <param name="sources"></param>
        internal ObservedIntegers(DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<int> values, IReadOnlyList<SourceDetails> sources) : base(firstSeen, lastSeen, count, recent, serializedAdditionalRawData)
        {
            Values = values;
            Sources = sources;
        }

        /// <summary> Gets the values. </summary>
        public IReadOnlyList<int> Values { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
    }
}
