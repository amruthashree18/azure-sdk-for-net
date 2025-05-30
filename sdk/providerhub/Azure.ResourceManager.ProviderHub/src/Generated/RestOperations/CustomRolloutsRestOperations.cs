// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    internal partial class CustomRolloutsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CustomRolloutsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CustomRolloutsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-20";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string providerNamespace, string rolloutName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts/", false);
            uri.AppendPath(rolloutName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string providerNamespace, string rolloutName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts/", false);
            uri.AppendPath(rolloutName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the custom rollout details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CustomRolloutData>> GetAsync(string subscriptionId, string providerNamespace, string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var message = CreateGetRequest(subscriptionId, providerNamespace, rolloutName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CustomRolloutData.DeserializeCustomRolloutData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CustomRolloutData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the custom rollout details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CustomRolloutData> Get(string subscriptionId, string providerNamespace, string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var message = CreateGetRequest(subscriptionId, providerNamespace, rolloutName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CustomRolloutData.DeserializeCustomRolloutData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CustomRolloutData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string providerNamespace, string rolloutName, CustomRolloutData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts/", false);
            uri.AppendPath(rolloutName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string providerNamespace, string rolloutName, CustomRolloutData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts/", false);
            uri.AppendPath(rolloutName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates the rollout details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The custom rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/>, <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CustomRolloutData>> CreateOrUpdateAsync(string subscriptionId, string providerNamespace, string rolloutName, CustomRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, providerNamespace, rolloutName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CustomRolloutData.DeserializeCustomRolloutData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates the rollout details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The custom rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/>, <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CustomRolloutData> CreateOrUpdate(string subscriptionId, string providerNamespace, string rolloutName, CustomRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, providerNamespace, rolloutName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CustomRolloutData.DeserializeCustomRolloutData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProviderRegistrationRequestUri(string subscriptionId, string providerNamespace)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByProviderRegistrationRequest(string subscriptionId, string providerNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/customRollouts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of the custom rollouts for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CustomRolloutListResult>> ListByProviderRegistrationAsync(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationRequest(subscriptionId, providerNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CustomRolloutListResult.DeserializeCustomRolloutListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of the custom rollouts for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CustomRolloutListResult> ListByProviderRegistration(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationRequest(subscriptionId, providerNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CustomRolloutListResult.DeserializeCustomRolloutListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProviderRegistrationNextPageRequestUri(string nextLink, string subscriptionId, string providerNamespace)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByProviderRegistrationNextPageRequest(string nextLink, string subscriptionId, string providerNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of the custom rollouts for the given provider. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CustomRolloutListResult>> ListByProviderRegistrationNextPageAsync(string nextLink, string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationNextPageRequest(nextLink, subscriptionId, providerNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CustomRolloutListResult.DeserializeCustomRolloutListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of the custom rollouts for the given provider. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CustomRolloutListResult> ListByProviderRegistrationNextPage(string nextLink, string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateListByProviderRegistrationNextPageRequest(nextLink, subscriptionId, providerNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CustomRolloutListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CustomRolloutListResult.DeserializeCustomRolloutListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
