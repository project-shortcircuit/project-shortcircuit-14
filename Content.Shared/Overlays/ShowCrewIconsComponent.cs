// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 SlamBamActionman <83650252+SlamBamActionman@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;

namespace Content.Shared.Overlays;

/// <summary>
///     This component allows you to see a crew border icon above mobs. The HUD will include a green border around jobs that are considered crew according to <see cref="JobIconPrototype.IsCrewJob"/>.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(raiseAfterAutoHandleState: true)]
public sealed partial class ShowCrewIconsComponent : Component
{
    /// <summary>
    /// If true, the HUD will include a yellow border around all icons, to indicate crew uncertainty.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool UncertainCrewBorder = false;
}
