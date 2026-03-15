// SPDX-FileCopyrightText: 2024 ShadowCommander <10494922+ShadowCommander@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.GameStates;

namespace Content.Shared.Foldable;

[RegisterComponent, NetworkedComponent]
[Access(typeof(DeployFoldableSystem))]
public sealed partial class DeployFoldableComponent : Component;
