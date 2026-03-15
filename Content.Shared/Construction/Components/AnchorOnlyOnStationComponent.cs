// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Samuka <47865393+Samuka-C@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.Construction.Components;

/// <summary>
/// If a entity has this component it can only be anchored to the station
/// </summary>
[RegisterComponent]
public sealed partial class AnchorOnlyOnStationComponent : Component
{
    /// <summary>
    /// Pop up message when you try to anchor the entity on any grid that isn't the station grid
    /// </summary>
    [DataField]
    public LocId PopupMessageAnchorFail = "anchorable-fail-not-on-station";
}
