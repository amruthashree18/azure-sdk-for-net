// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class IntervalSummary
    {
        internal static IntervalSummary DeserializeIntervalSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? startMinute = default;
            int? endMinute = default;
            int? totalMinutes = default;
            string shortPhrase = default;
            string briefPhrase = default;
            string longPhrase = default;
            IconCode? iconCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startMinute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startMinute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endMinute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endMinute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("shortPhrase"u8))
                {
                    shortPhrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("briefPhrase"u8))
                {
                    briefPhrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("longPhrase"u8))
                {
                    longPhrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconCode = new IconCode(property.Value.GetInt32());
                    continue;
                }
            }
            return new IntervalSummary(
                startMinute,
                endMinute,
                totalMinutes,
                shortPhrase,
                briefPhrase,
                longPhrase,
                iconCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static IntervalSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIntervalSummary(document.RootElement);
        }
    }
}
