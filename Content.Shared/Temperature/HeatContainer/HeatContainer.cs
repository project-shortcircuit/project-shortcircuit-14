// SPDX-FileCopyrightText: 2025 ArtisticRoomba <145879011+ArtisticRoomba@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Atmos;
using Content.Shared.Atmos.EntitySystems;
using Robust.Shared.Serialization;

namespace Content.Shared.Temperature.HeatContainer;

/// <summary>
/// A general-purpose container for heat energy.
/// </summary>
[Serializable, NetSerializable, DataDefinition]
[Access(typeof(HeatContainerHelpers), typeof(SharedAtmosphereSystem))]
public partial struct HeatContainer : IHeatContainer
{
    /// <inheritdoc/>
    [DataField]
    public float HeatCapacity { get; set; } = 4000f; // about 1kg of water

    /// <inheritdoc/>
    [DataField]
    public float Temperature { get; set; } = Atmospherics.T20C; // room temperature

    /// <inheritdoc/>
    [ViewVariables]
    public float TemperatureC => TemperatureHelpers.KelvinToCelsius(Temperature);

    /// <inheritdoc/>
    [ViewVariables]
    public float InternalEnergy => Temperature * HeatCapacity;

    public HeatContainer(float heatCapacity, float temperature)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(heatCapacity);
        ArgumentOutOfRangeException.ThrowIfNegative(temperature);
        HeatCapacity = heatCapacity;
        Temperature = temperature;
    }

    public HeatContainer(float heatCapacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(heatCapacity);
        HeatCapacity = heatCapacity;
    }
}
