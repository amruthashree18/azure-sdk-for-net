// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class BinaryHardeningFeatures : IUtf8JsonSerializable, IJsonModel<BinaryHardeningFeatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BinaryHardeningFeatures>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BinaryHardeningFeatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardeningFeatures)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NoExecute))
            {
                writer.WritePropertyName("noExecute"u8);
                writer.WriteBooleanValue(NoExecute.Value);
            }
            if (Optional.IsDefined(PositionIndependentExecutable))
            {
                writer.WritePropertyName("positionIndependentExecutable"u8);
                writer.WriteBooleanValue(PositionIndependentExecutable.Value);
            }
            if (Optional.IsDefined(RelocationReadOnly))
            {
                writer.WritePropertyName("relocationReadOnly"u8);
                writer.WriteBooleanValue(RelocationReadOnly.Value);
            }
            if (Optional.IsDefined(Canary))
            {
                writer.WritePropertyName("canary"u8);
                writer.WriteBooleanValue(Canary.Value);
            }
            if (Optional.IsDefined(Stripped))
            {
                writer.WritePropertyName("stripped"u8);
                writer.WriteBooleanValue(Stripped.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BinaryHardeningFeatures IJsonModel<BinaryHardeningFeatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardeningFeatures)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBinaryHardeningFeatures(document.RootElement, options);
        }

        internal static BinaryHardeningFeatures DeserializeBinaryHardeningFeatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? noExecute = default;
            bool? positionIndependentExecutable = default;
            bool? relocationReadOnly = default;
            bool? canary = default;
            bool? stripped = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("noExecute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noExecute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("positionIndependentExecutable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    positionIndependentExecutable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relocationReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relocationReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("canary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stripped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stripped = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BinaryHardeningFeatures(
                noExecute,
                positionIndependentExecutable,
                relocationReadOnly,
                canary,
                stripped,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BinaryHardeningFeatures>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BinaryHardeningFeatures)} does not support writing '{options.Format}' format.");
            }
        }

        BinaryHardeningFeatures IPersistableModel<BinaryHardeningFeatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBinaryHardeningFeatures(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BinaryHardeningFeatures)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BinaryHardeningFeatures>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
