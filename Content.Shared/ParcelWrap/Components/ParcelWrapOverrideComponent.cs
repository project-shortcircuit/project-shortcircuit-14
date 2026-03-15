// SPDX-FileCopyrightText: 2025 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Centronias <me@centronias.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.ParcelWrap.Components;

/// <summary>
/// Added to an entity to override the datafields in <see cref="ParcelWrapComponent"/> when it is being wrapped.
/// Use this for special, non-item parcel types, for example Urist-shaped parcels.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ParcelWrapOverrideComponent : Component
{
    /// <summary>
    /// The <see cref="EntityPrototype"/> of the parcel created by wrapping this entity.
    /// </summary>
    [DataField(required: true), AutoNetworkedField]
    public EntProtoId<WrappedParcelComponent> ParcelPrototype;

    /// <summary>
    /// How long it takes to use this to wrap something.
    /// </summary>
    [DataField, AutoNetworkedField]
    public TimeSpan? WrapDelay;
}
