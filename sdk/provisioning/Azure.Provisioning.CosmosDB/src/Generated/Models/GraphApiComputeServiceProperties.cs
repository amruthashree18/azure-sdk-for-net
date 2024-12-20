// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Properties for GraphAPIComputeServiceResource.
/// </summary>
public partial class GraphApiComputeServiceProperties : CosmosDBServiceProperties
{
    /// <summary>
    /// GraphAPICompute endpoint for the service.
    /// </summary>
    public BicepValue<string> GraphApiComputeEndpoint 
    {
        get { Initialize(); return _graphApiComputeEndpoint!; }
        set { Initialize(); _graphApiComputeEndpoint!.Assign(value); }
    }
    private BicepValue<string>? _graphApiComputeEndpoint;

    /// <summary>
    /// An array that contains all of the locations for the service.
    /// </summary>
    public BicepList<GraphApiComputeRegionalService> Locations 
    {
        get { Initialize(); return _locations!; }
    }
    private BicepList<GraphApiComputeRegionalService>? _locations;

    /// <summary>
    /// Creates a new GraphApiComputeServiceProperties.
    /// </summary>
    public GraphApiComputeServiceProperties() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// GraphApiComputeServiceProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("serviceType", ["serviceType"], defaultValue: "GraphAPICompute");
        _graphApiComputeEndpoint = DefineProperty<string>("GraphApiComputeEndpoint", ["graphApiComputeEndpoint"]);
        _locations = DefineListProperty<GraphApiComputeRegionalService>("Locations", ["locations"], isOutput: true);
    }
}
