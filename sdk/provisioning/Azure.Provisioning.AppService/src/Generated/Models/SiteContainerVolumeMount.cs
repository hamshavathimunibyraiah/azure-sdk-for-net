// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The SiteContainerVolumeMount.
/// </summary>
public partial class SiteContainerVolumeMount : ProvisionableConstruct
{
    /// <summary>
    /// Sub path in the volume where volume is mounted from.
    /// </summary>
    public BicepValue<string> VolumeSubPath 
    {
        get { Initialize(); return _volumeSubPath!; }
        set { Initialize(); _volumeSubPath!.Assign(value); }
    }
    private BicepValue<string>? _volumeSubPath;

    /// <summary>
    /// Target path on the container where volume is mounted on.
    /// </summary>
    public BicepValue<string> ContainerMountPath 
    {
        get { Initialize(); return _containerMountPath!; }
        set { Initialize(); _containerMountPath!.Assign(value); }
    }
    private BicepValue<string>? _containerMountPath;

    /// <summary>
    /// Config Data to be mounted on the volume.
    /// </summary>
    public BicepValue<string> Data 
    {
        get { Initialize(); return _data!; }
        set { Initialize(); _data!.Assign(value); }
    }
    private BicepValue<string>? _data;

    /// <summary>
    /// Boolean to specify if the mount is read only on the container.
    /// </summary>
    public BicepValue<bool> IsReadOnly 
    {
        get { Initialize(); return _isReadOnly!; }
        set { Initialize(); _isReadOnly!.Assign(value); }
    }
    private BicepValue<bool>? _isReadOnly;

    /// <summary>
    /// Creates a new SiteContainerVolumeMount.
    /// </summary>
    public SiteContainerVolumeMount()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SiteContainerVolumeMount.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _volumeSubPath = DefineProperty<string>("VolumeSubPath", ["volumeSubPath"]);
        _containerMountPath = DefineProperty<string>("ContainerMountPath", ["containerMountPath"]);
        _data = DefineProperty<string>("Data", ["data"]);
        _isReadOnly = DefineProperty<bool>("IsReadOnly", ["readOnly"]);
    }
}
