// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class KnowledgeBaseAnswerPrompt
    {
        internal static KnowledgeBaseAnswerPrompt DeserializeKnowledgeBaseAnswerPrompt(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? displayOrder = default;
            int? qnaId = default;
            string displayText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayOrder = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("qnaId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qnaId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
            }
            return new KnowledgeBaseAnswerPrompt(displayOrder, qnaId, displayText);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static KnowledgeBaseAnswerPrompt FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeKnowledgeBaseAnswerPrompt(document.RootElement);
        }
    }
}
