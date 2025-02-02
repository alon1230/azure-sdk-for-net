// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class BillingInformation : IUtf8JsonSerializable, IJsonModel<BillingInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BillingCurrencyTotalPaidAmount != null)
            {
                writer.WritePropertyName("billingCurrencyTotalPaidAmount"u8);
                writer.WriteObjectValue(BillingCurrencyTotalPaidAmount);
            }
            if (BillingCurrencyProratedAmount != null)
            {
                writer.WritePropertyName("billingCurrencyProratedAmount"u8);
                writer.WriteObjectValue(BillingCurrencyProratedAmount);
            }
            if (BillingCurrencyRemainingCommitmentAmount != null)
            {
                writer.WritePropertyName("billingCurrencyRemainingCommitmentAmount"u8);
                writer.WriteObjectValue(BillingCurrencyRemainingCommitmentAmount);
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

        BillingInformation IJsonModel<BillingInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingInformation(document.RootElement, options);
        }

        internal static BillingInformation DeserializeBillingInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PurchasePrice billingCurrencyTotalPaidAmount = default;
            PurchasePrice billingCurrencyProratedAmount = default;
            PurchasePrice billingCurrencyRemainingCommitmentAmount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrencyTotalPaidAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingInformation(billingCurrencyTotalPaidAmount, billingCurrencyProratedAmount, billingCurrencyRemainingCommitmentAmount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingInformation)} does not support '{options.Format}' format.");
            }
        }

        BillingInformation IPersistableModel<BillingInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
