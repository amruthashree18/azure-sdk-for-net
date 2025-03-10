// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentApiKeyRequestProperties. </summary>
    public partial class NginxDeploymentApiKeyRequestProperties
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

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentApiKeyRequestProperties"/>. </summary>
        public NginxDeploymentApiKeyRequestProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentApiKeyRequestProperties"/>. </summary>
        /// <param name="secretText"> Secret text to be used as a Dataplane API Key. This is a write only property that can never be read back, but the first three characters will be returned in the 'hint' property. </param>
        /// <param name="endOn"> The time after which this Dataplane API Key is no longer valid. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxDeploymentApiKeyRequestProperties(string secretText, DateTimeOffset? endOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecretText = secretText;
            EndOn = endOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Secret text to be used as a Dataplane API Key. This is a write only property that can never be read back, but the first three characters will be returned in the 'hint' property. </summary>
        public string SecretText { get; set; }
        /// <summary> The time after which this Dataplane API Key is no longer valid. </summary>
        public DateTimeOffset? EndOn { get; set; }
    }
}
