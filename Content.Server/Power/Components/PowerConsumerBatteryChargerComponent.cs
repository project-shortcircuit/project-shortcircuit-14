// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Samuka <47865393+Samuka-C@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Server.Power.Components;

/// <summary>
/// Charges the battery from a entity with <see cref="PowerConsumerComponent"/>
/// </summary>
[RegisterComponent]
public sealed partial class PowerConsumerBatteryChargerComponent : Component;
