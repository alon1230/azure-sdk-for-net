// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class DomainAsset : IUtf8JsonSerializable, IJsonModel<DomainAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainAsset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DomainAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainAsset)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Domain != null)
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (WhoisId.HasValue)
            {
                writer.WritePropertyName("whoisId"u8);
                writer.WriteNumberValue(WhoisId.Value);
            }
            if (!(RegistrarIanaIds is ChangeTrackingList<ObservedInteger> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("registrarIanaIds"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarIanaIds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrantContacts is ChangeTrackingList<ObservedString> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("registrantContacts"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantContacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrantOrgs is ChangeTrackingList<ObservedString> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("registrantOrgs"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantOrgs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AdminContacts is ChangeTrackingList<ObservedString> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("adminContacts"u8);
                writer.WriteStartArray();
                foreach (var item in AdminContacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TechnicalContacts is ChangeTrackingList<ObservedString> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("technicalContacts"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalContacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AlexaInfos is ChangeTrackingList<AlexaInfo> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("alexaInfos"u8);
                writer.WriteStartArray();
                foreach (var item in AlexaInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(NameServers is ChangeTrackingList<ObservedString> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("nameServers"u8);
                writer.WriteStartArray();
                foreach (var item in NameServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(MailServers is ChangeTrackingList<ObservedString> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("mailServers"u8);
                writer.WriteStartArray();
                foreach (var item in MailServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(WhoisServers is ChangeTrackingList<ObservedString> collection7 && collection7.IsUndefined))
            {
                writer.WritePropertyName("whoisServers"u8);
                writer.WriteStartArray();
                foreach (var item in WhoisServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DomainStatuses is ChangeTrackingList<ObservedString> collection8 && collection8.IsUndefined))
            {
                writer.WritePropertyName("domainStatuses"u8);
                writer.WriteStartArray();
                foreach (var item in DomainStatuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrarCreatedAt is ChangeTrackingList<ObservedLong> collection9 && collection9.IsUndefined))
            {
                writer.WritePropertyName("registrarCreatedAt"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarCreatedAt)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrarUpdatedAt is ChangeTrackingList<ObservedLong> collection10 && collection10.IsUndefined))
            {
                writer.WritePropertyName("registrarUpdatedAt"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarUpdatedAt)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrarExpiresAt is ChangeTrackingList<ObservedLong> collection11 && collection11.IsUndefined))
            {
                writer.WritePropertyName("registrarExpiresAt"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarExpiresAt)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SoaRecords is ChangeTrackingList<SoaRecord> collection12 && collection12.IsUndefined))
            {
                writer.WritePropertyName("soaRecords"u8);
                writer.WriteStartArray();
                foreach (var item in SoaRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DetailedFromWhoisAt.HasValue)
            {
                writer.WritePropertyName("detailedFromWhoisAt"u8);
                writer.WriteStringValue(DetailedFromWhoisAt.Value, "O");
            }
            if (!(RegistrarNames is ChangeTrackingList<ObservedString> collection13 && collection13.IsUndefined))
            {
                writer.WritePropertyName("registrarNames"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Sources is ChangeTrackingList<SourceDetails> collection14 && collection14.IsUndefined))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FirstSeen.HasValue)
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (LastSeen.HasValue)
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (!(ParkedDomain is ChangeTrackingList<ObservedBoolean> collection15 && collection15.IsUndefined))
            {
                writer.WritePropertyName("parkedDomain"u8);
                writer.WriteStartArray();
                foreach (var item in ParkedDomain)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrantNames is ChangeTrackingList<ObservedString> collection16 && collection16.IsUndefined))
            {
                writer.WritePropertyName("registrantNames"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AdminNames is ChangeTrackingList<ObservedString> collection17 && collection17.IsUndefined))
            {
                writer.WritePropertyName("adminNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdminNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TechnicalNames is ChangeTrackingList<ObservedString> collection18 && collection18.IsUndefined))
            {
                writer.WritePropertyName("technicalNames"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AdminOrgs is ChangeTrackingList<ObservedString> collection19 && collection19.IsUndefined))
            {
                writer.WritePropertyName("adminOrgs"u8);
                writer.WriteStartArray();
                foreach (var item in AdminOrgs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TechnicalOrgs is ChangeTrackingList<ObservedString> collection20 && collection20.IsUndefined))
            {
                writer.WritePropertyName("technicalOrgs"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalOrgs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RegistrantPhones is ChangeTrackingList<ObservedString> collection21 && collection21.IsUndefined))
            {
                writer.WritePropertyName("registrantPhones"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantPhones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AdminPhones is ChangeTrackingList<ObservedString> collection22 && collection22.IsUndefined))
            {
                writer.WritePropertyName("adminPhones"u8);
                writer.WriteStartArray();
                foreach (var item in AdminPhones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TechnicalPhones is ChangeTrackingList<ObservedString> collection23 && collection23.IsUndefined))
            {
                writer.WritePropertyName("technicalPhones"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalPhones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DomainAsset IJsonModel<DomainAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainAsset)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainAsset(document.RootElement, options);
        }

        internal static DomainAsset DeserializeDomainAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domain = default;
            long? whoisId = default;
            IReadOnlyList<ObservedInteger> registrarIanaIds = default;
            IReadOnlyList<ObservedString> registrantContacts = default;
            IReadOnlyList<ObservedString> registrantOrgs = default;
            IReadOnlyList<ObservedString> adminContacts = default;
            IReadOnlyList<ObservedString> technicalContacts = default;
            IReadOnlyList<AlexaInfo> alexaInfos = default;
            IReadOnlyList<ObservedString> nameServers = default;
            IReadOnlyList<ObservedString> mailServers = default;
            IReadOnlyList<ObservedString> whoisServers = default;
            IReadOnlyList<ObservedString> domainStatuses = default;
            IReadOnlyList<ObservedLong> registrarCreatedAt = default;
            IReadOnlyList<ObservedLong> registrarUpdatedAt = default;
            IReadOnlyList<ObservedLong> registrarExpiresAt = default;
            IReadOnlyList<SoaRecord> soaRecords = default;
            DateTimeOffset? detailedFromWhoisAt = default;
            IReadOnlyList<ObservedString> registrarNames = default;
            IReadOnlyList<SourceDetails> sources = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            IReadOnlyList<ObservedBoolean> parkedDomain = default;
            IReadOnlyList<ObservedString> registrantNames = default;
            IReadOnlyList<ObservedString> adminNames = default;
            IReadOnlyList<ObservedString> technicalNames = default;
            IReadOnlyList<ObservedString> adminOrgs = default;
            IReadOnlyList<ObservedString> technicalOrgs = default;
            IReadOnlyList<ObservedString> registrantPhones = default;
            IReadOnlyList<ObservedString> adminPhones = default;
            IReadOnlyList<ObservedString> technicalPhones = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("whoisId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    whoisId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("registrarIanaIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedInteger> array = new List<ObservedInteger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedInteger.DeserializeObservedInteger(item, options));
                    }
                    registrarIanaIds = array;
                    continue;
                }
                if (property.NameEquals("registrantContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantContacts = array;
                    continue;
                }
                if (property.NameEquals("registrantOrgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantOrgs = array;
                    continue;
                }
                if (property.NameEquals("adminContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminContacts = array;
                    continue;
                }
                if (property.NameEquals("technicalContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalContacts = array;
                    continue;
                }
                if (property.NameEquals("alexaInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlexaInfo> array = new List<AlexaInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlexaInfo.DeserializeAlexaInfo(item, options));
                    }
                    alexaInfos = array;
                    continue;
                }
                if (property.NameEquals("nameServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    nameServers = array;
                    continue;
                }
                if (property.NameEquals("mailServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    mailServers = array;
                    continue;
                }
                if (property.NameEquals("whoisServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    whoisServers = array;
                    continue;
                }
                if (property.NameEquals("domainStatuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    domainStatuses = array;
                    continue;
                }
                if (property.NameEquals("registrarCreatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    registrarCreatedAt = array;
                    continue;
                }
                if (property.NameEquals("registrarUpdatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    registrarUpdatedAt = array;
                    continue;
                }
                if (property.NameEquals("registrarExpiresAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    registrarExpiresAt = array;
                    continue;
                }
                if (property.NameEquals("soaRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SoaRecord> array = new List<SoaRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SoaRecord.DeserializeSoaRecord(item, options));
                    }
                    soaRecords = array;
                    continue;
                }
                if (property.NameEquals("detailedFromWhoisAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detailedFromWhoisAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("registrarNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrarNames = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SourceDetails> array = new List<SourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceDetails.DeserializeSourceDetails(item, options));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("parkedDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item, options));
                    }
                    parkedDomain = array;
                    continue;
                }
                if (property.NameEquals("registrantNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantNames = array;
                    continue;
                }
                if (property.NameEquals("adminNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminNames = array;
                    continue;
                }
                if (property.NameEquals("technicalNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalNames = array;
                    continue;
                }
                if (property.NameEquals("adminOrgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminOrgs = array;
                    continue;
                }
                if (property.NameEquals("technicalOrgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalOrgs = array;
                    continue;
                }
                if (property.NameEquals("registrantPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantPhones = array;
                    continue;
                }
                if (property.NameEquals("adminPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminPhones = array;
                    continue;
                }
                if (property.NameEquals("technicalPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalPhones = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DomainAsset(
                domain,
                whoisId,
                registrarIanaIds ?? new ChangeTrackingList<ObservedInteger>(),
                registrantContacts ?? new ChangeTrackingList<ObservedString>(),
                registrantOrgs ?? new ChangeTrackingList<ObservedString>(),
                adminContacts ?? new ChangeTrackingList<ObservedString>(),
                technicalContacts ?? new ChangeTrackingList<ObservedString>(),
                alexaInfos ?? new ChangeTrackingList<AlexaInfo>(),
                nameServers ?? new ChangeTrackingList<ObservedString>(),
                mailServers ?? new ChangeTrackingList<ObservedString>(),
                whoisServers ?? new ChangeTrackingList<ObservedString>(),
                domainStatuses ?? new ChangeTrackingList<ObservedString>(),
                registrarCreatedAt ?? new ChangeTrackingList<ObservedLong>(),
                registrarUpdatedAt ?? new ChangeTrackingList<ObservedLong>(),
                registrarExpiresAt ?? new ChangeTrackingList<ObservedLong>(),
                soaRecords ?? new ChangeTrackingList<SoaRecord>(),
                detailedFromWhoisAt,
                registrarNames ?? new ChangeTrackingList<ObservedString>(),
                sources ?? new ChangeTrackingList<SourceDetails>(),
                firstSeen,
                lastSeen,
                count,
                parkedDomain ?? new ChangeTrackingList<ObservedBoolean>(),
                registrantNames ?? new ChangeTrackingList<ObservedString>(),
                adminNames ?? new ChangeTrackingList<ObservedString>(),
                technicalNames ?? new ChangeTrackingList<ObservedString>(),
                adminOrgs ?? new ChangeTrackingList<ObservedString>(),
                technicalOrgs ?? new ChangeTrackingList<ObservedString>(),
                registrantPhones ?? new ChangeTrackingList<ObservedString>(),
                adminPhones ?? new ChangeTrackingList<ObservedString>(),
                technicalPhones ?? new ChangeTrackingList<ObservedString>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainAsset)} does not support '{options.Format}' format.");
            }
        }

        DomainAsset IPersistableModel<DomainAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainAsset)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DomainAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDomainAsset(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
