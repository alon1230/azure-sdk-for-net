// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> A list of services that support encryption. </summary>
    public partial class StorageAccountEncryptionServices
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountEncryptionServices"/>. </summary>
        public StorageAccountEncryptionServices()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountEncryptionServices"/>. </summary>
        /// <param name="blob"> The encryption function of the blob storage service. </param>
        /// <param name="file"> The encryption function of the file storage service. </param>
        /// <param name="table"> The encryption function of the table storage service. </param>
        /// <param name="queue"> The encryption function of the queue storage service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountEncryptionServices(StorageEncryptionService blob, StorageEncryptionService file, StorageEncryptionService table, StorageEncryptionService queue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Blob = blob;
            File = file;
            Table = table;
            Queue = queue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The encryption function of the blob storage service. </summary>
        public StorageEncryptionService Blob { get; set; }
        /// <summary> The encryption function of the file storage service. </summary>
        public StorageEncryptionService File { get; set; }
        /// <summary> The encryption function of the table storage service. </summary>
        public StorageEncryptionService Table { get; set; }
        /// <summary> The encryption function of the queue storage service. </summary>
        public StorageEncryptionService Queue { get; set; }
    }
}
