// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting
{
    public partial class AutoStopCriteria : IUtf8JsonSerializable, IJsonModel<AutoStopCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoStopCriteria>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoStopCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoStopCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoStopCriteria)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AutoStopDisabled))
            {
                writer.WritePropertyName("autoStopDisabled"u8);
                writer.WriteBooleanValue(AutoStopDisabled.Value);
            }
            if (Optional.IsDefined(ErrorRate))
            {
                writer.WritePropertyName("errorRate"u8);
                writer.WriteNumberValue(ErrorRate.Value);
            }
            if (Optional.IsDefined(ErrorRateTimeWindow))
            {
                writer.WritePropertyName("errorRateTimeWindowInSeconds"u8);
                writer.WriteNumberValue(Convert.ToInt32(ErrorRateTimeWindow.Value.ToString("%s")));
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

        AutoStopCriteria IJsonModel<AutoStopCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoStopCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoStopCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoStopCriteria(document.RootElement, options);
        }

        internal static AutoStopCriteria DeserializeAutoStopCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? autoStopDisabled = default;
            float? errorRate = default;
            TimeSpan? errorRateTimeWindowInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoStopDisabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoStopDisabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("errorRateTimeWindowInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorRateTimeWindowInSeconds = TimeSpan.FromSeconds(property.Value.GetInt32());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoStopCriteria(autoStopDisabled, errorRate, errorRateTimeWindowInSeconds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoStopCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoStopCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoStopCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        AutoStopCriteria IPersistableModel<AutoStopCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoStopCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutoStopCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoStopCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoStopCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AutoStopCriteria FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAutoStopCriteria(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
