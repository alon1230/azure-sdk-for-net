// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmNicDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmNicDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmNicDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmNicDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && NicId != null)
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            if (IsPrimaryNic != null)
            {
                writer.WritePropertyName("isPrimaryNic"u8);
                writer.WriteStringValue(IsPrimaryNic);
            }
            if (IsSelectedForFailover != null)
            {
                writer.WritePropertyName("isSelectedForFailover"u8);
                writer.WriteStringValue(IsSelectedForFailover);
            }
            if (options.Format != "W" && SourceIPAddress != null)
            {
                writer.WritePropertyName("sourceIPAddress"u8);
                writer.WriteStringValue(SourceIPAddress.ToString());
            }
            if (options.Format != "W" && SourceIPAddressType.HasValue)
            {
                writer.WritePropertyName("sourceIPAddressType"u8);
                writer.WriteStringValue(SourceIPAddressType.Value.ToString());
            }
            if (options.Format != "W" && SourceNetworkId != null)
            {
                writer.WritePropertyName("sourceNetworkId"u8);
                writer.WriteStringValue(SourceNetworkId);
            }
            if (options.Format != "W" && SourceSubnetName != null)
            {
                writer.WritePropertyName("sourceSubnetName"u8);
                writer.WriteStringValue(SourceSubnetName);
            }
            if (TargetIPAddress != null)
            {
                writer.WritePropertyName("targetIPAddress"u8);
                writer.WriteStringValue(TargetIPAddress.ToString());
            }
            if (TargetIPAddressType.HasValue)
            {
                writer.WritePropertyName("targetIPAddressType"u8);
                writer.WriteStringValue(TargetIPAddressType.Value.ToString());
            }
            if (TargetSubnetName != null)
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (TestSubnetName != null)
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (TestIPAddress != null)
            {
                writer.WritePropertyName("testIPAddress"u8);
                writer.WriteStringValue(TestIPAddress.ToString());
            }
            if (TestIPAddressType.HasValue)
            {
                writer.WritePropertyName("testIPAddressType"u8);
                writer.WriteStringValue(TestIPAddressType.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InMageRcmNicDetails IJsonModel<InMageRcmNicDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmNicDetails(document.RootElement, options);
        }

        internal static InMageRcmNicDetails DeserializeInMageRcmNicDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string isPrimaryNic = default;
            string isSelectedForFailover = default;
            IPAddress sourceIPAddress = default;
            SiteRecoveryEthernetAddressType? sourceIPAddressType = default;
            ResourceIdentifier sourceNetworkId = default;
            string sourceSubnetName = default;
            IPAddress targetIPAddress = default;
            SiteRecoveryEthernetAddressType? targetIPAddressType = default;
            string targetSubnetName = default;
            string testSubnetName = default;
            IPAddress testIPAddress = default;
            SiteRecoveryEthernetAddressType? testIPAddressType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimaryNic"u8))
                {
                    isPrimaryNic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSelectedForFailover"u8))
                {
                    isSelectedForFailover = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceSubnetName"u8))
                {
                    sourceSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmNicDetails(
                nicId,
                isPrimaryNic,
                isSelectedForFailover,
                sourceIPAddress,
                sourceIPAddressType,
                sourceNetworkId,
                sourceSubnetName,
                targetIPAddress,
                targetIPAddressType,
                targetSubnetName,
                testSubnetName,
                testIPAddress,
                testIPAddressType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmNicDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmNicDetails IPersistableModel<InMageRcmNicDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmNicDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmNicDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
