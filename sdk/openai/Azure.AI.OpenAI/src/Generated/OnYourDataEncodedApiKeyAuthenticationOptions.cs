// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication options for Azure OpenAI On Your Data when using an Elasticsearch encoded API key. </summary>
    public partial class OnYourDataEncodedApiKeyAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataEncodedApiKeyAuthenticationOptions"/>. </summary>
        /// <param name="encodedApiKey"> The encoded API key to use for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="encodedApiKey"/> is null. </exception>
        public OnYourDataEncodedApiKeyAuthenticationOptions(string encodedApiKey)
        {
            if (encodedApiKey == null)
            {
                throw new ArgumentNullException(nameof(encodedApiKey));
            }

            Type = OnYourDataAuthenticationType.EncodedApiKey;
            EncodedApiKey = encodedApiKey;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataEncodedApiKeyAuthenticationOptions"/>. </summary>
        /// <param name="type"> The authentication type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="encodedApiKey"> The encoded API key to use for authentication. </param>
        internal OnYourDataEncodedApiKeyAuthenticationOptions(OnYourDataAuthenticationType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string encodedApiKey) : base(type, serializedAdditionalRawData)
        {
            EncodedApiKey = encodedApiKey;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataEncodedApiKeyAuthenticationOptions"/> for deserialization. </summary>
        internal OnYourDataEncodedApiKeyAuthenticationOptions()
        {
        }

        /// <summary> The encoded API key to use for authentication. </summary>
        public string EncodedApiKey { get; }
    }
}
