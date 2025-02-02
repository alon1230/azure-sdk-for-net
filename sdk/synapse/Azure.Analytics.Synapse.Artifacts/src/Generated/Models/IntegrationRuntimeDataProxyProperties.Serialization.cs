// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IntegrationRuntimeDataProxyPropertiesConverter))]
    public partial class IntegrationRuntimeDataProxyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (StagingLinkedService != null)
            {
                writer.WritePropertyName("stagingLinkedService"u8);
                writer.WriteObjectValue(StagingLinkedService);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeDataProxyProperties DeserializeIntegrationRuntimeDataProxyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityReference connectVia = default;
            EntityReference stagingLinkedService = default;
            string path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("stagingLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stagingLinkedService = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationRuntimeDataProxyProperties(connectVia, stagingLinkedService, path);
        }

        internal partial class IntegrationRuntimeDataProxyPropertiesConverter : JsonConverter<IntegrationRuntimeDataProxyProperties>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeDataProxyProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IntegrationRuntimeDataProxyProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeDataProxyProperties(document.RootElement);
            }
        }
    }
}
