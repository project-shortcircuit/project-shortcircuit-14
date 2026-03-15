// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Thinbug <101073555+Thinbug0@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.GameStates;

namespace Content.Shared.GhostTypes;

/// <summary>
/// Stores the damage an entity took before their body is destroyed inside it's mind LastBodyDamageComponent
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class StoreDamageTakenOnMindComponent : Component;
