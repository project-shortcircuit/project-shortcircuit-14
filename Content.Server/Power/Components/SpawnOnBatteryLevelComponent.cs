// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Samuka <47865393+Samuka-C@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Prototypes;

namespace Content.Server.Power.Components;

/// <summary>
/// Spawns a entity when the battery reaches a certain percentage or amount of power.
/// It also consumes that much power when spawning the entity.
/// </summary>
[RegisterComponent]
public sealed partial class SpawnOnBatteryLevelComponent : Component
{
    /// <summary>
    /// Entity prototype to spawn.
    /// </summary>
    [DataField(required: true)]
    public EntProtoId Prototype = string.Empty;

    /// <summary>
    /// Amount of power in the battery (in joules) to spawn entity
    /// </summary>
    [DataField]
    public float Charge;
}
