// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// Message Count Details.
/// </summary>
public partial class MessageCountDetails : ProvisionableConstruct
{
    /// <summary>
    /// Number of active messages in the queue, topic, or subscription.
    /// </summary>
    public BicepValue<long> ActiveMessageCount { get => _activeMessageCount; }
    private readonly BicepValue<long> _activeMessageCount;

    /// <summary>
    /// Number of messages that are dead lettered.
    /// </summary>
    public BicepValue<long> DeadLetterMessageCount { get => _deadLetterMessageCount; }
    private readonly BicepValue<long> _deadLetterMessageCount;

    /// <summary>
    /// Number of scheduled messages.
    /// </summary>
    public BicepValue<long> ScheduledMessageCount { get => _scheduledMessageCount; }
    private readonly BicepValue<long> _scheduledMessageCount;

    /// <summary>
    /// Number of messages transferred to another queue, topic, or subscription.
    /// </summary>
    public BicepValue<long> TransferMessageCount { get => _transferMessageCount; }
    private readonly BicepValue<long> _transferMessageCount;

    /// <summary>
    /// Number of messages transferred into dead letters.
    /// </summary>
    public BicepValue<long> TransferDeadLetterMessageCount { get => _transferDeadLetterMessageCount; }
    private readonly BicepValue<long> _transferDeadLetterMessageCount;

    /// <summary>
    /// Creates a new MessageCountDetails.
    /// </summary>
    public MessageCountDetails()
    {
        _activeMessageCount = BicepValue<long>.DefineProperty(this, "ActiveMessageCount", ["activeMessageCount"], isOutput: true);
        _deadLetterMessageCount = BicepValue<long>.DefineProperty(this, "DeadLetterMessageCount", ["deadLetterMessageCount"], isOutput: true);
        _scheduledMessageCount = BicepValue<long>.DefineProperty(this, "ScheduledMessageCount", ["scheduledMessageCount"], isOutput: true);
        _transferMessageCount = BicepValue<long>.DefineProperty(this, "TransferMessageCount", ["transferMessageCount"], isOutput: true);
        _transferDeadLetterMessageCount = BicepValue<long>.DefineProperty(this, "TransferDeadLetterMessageCount", ["transferDeadLetterMessageCount"], isOutput: true);
    }
}
