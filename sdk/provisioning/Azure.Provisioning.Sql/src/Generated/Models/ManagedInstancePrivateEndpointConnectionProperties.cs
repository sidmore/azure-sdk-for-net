// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Properties of a private endpoint connection.
/// </summary>
public partial class ManagedInstancePrivateEndpointConnectionProperties : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId 
    {
        get { Initialize(); return _privateEndpointId!; }
    }
    private BicepValue<ResourceIdentifier>? _privateEndpointId;

    /// <summary>
    /// Connection State of the Private Endpoint Connection.
    /// </summary>
    public ManagedInstancePrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState 
    {
        get { Initialize(); return _privateLinkServiceConnectionState!; }
    }
    private ManagedInstancePrivateLinkServiceConnectionStateProperty? _privateLinkServiceConnectionState;

    /// <summary>
    /// State of the Private Endpoint Connection.
    /// </summary>
    public BicepValue<string> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<string>? _provisioningState;

    /// <summary>
    /// Creates a new ManagedInstancePrivateEndpointConnectionProperties.
    /// </summary>
    public ManagedInstancePrivateEndpointConnectionProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedInstancePrivateEndpointConnectionProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _privateEndpointId = DefineProperty<ResourceIdentifier>("PrivateEndpointId", ["privateEndpoint", "id"], isOutput: true);
        _privateLinkServiceConnectionState = DefineModelProperty<ManagedInstancePrivateLinkServiceConnectionStateProperty>("PrivateLinkServiceConnectionState", ["privateLinkServiceConnectionState"], isOutput: true);
        _provisioningState = DefineProperty<string>("ProvisioningState", ["provisioningState"], isOutput: true);
    }
}
