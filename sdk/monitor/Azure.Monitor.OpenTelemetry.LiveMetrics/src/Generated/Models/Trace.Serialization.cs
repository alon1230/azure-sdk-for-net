// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class Trace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Message != null)
            {
                writer.WritePropertyName("Message"u8);
                writer.WriteStringValue(Message);
            }
            writer.WritePropertyName("DocumentType"u8);
            writer.WriteStringValue(DocumentType.ToString());
            if (!(DocumentStreamIds is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("DocumentStreamIds"u8);
                writer.WriteStartArray();
                foreach (var item in DocumentStreamIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Properties is ChangeTrackingList<KeyValuePairString> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("Properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
