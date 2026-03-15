// SPDX-FileCopyrightText: 2025 ArtisticRoomba <145879011+ArtisticRoomba@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using System.Numerics;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Trigger.Components.Effects;

/// <summary>
/// Randomly teleports the entity when triggered.
/// If TargetUser is true the user will be teleported instead.
/// Used for scram implants.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ScramOnTriggerComponent : BaseXOnTriggerComponent
{
    /// <summary>
    /// Up to how far to teleport the entity. Represented with X as Min Radius, and Y as Max Radius
    /// </summary>
    [DataField, AutoNetworkedField]
    public Vector2 TeleportRadius = new (10f, 15f);

    /// <summary>
    /// the sound to play when teleporting.
    /// </summary>
    [DataField, AutoNetworkedField]
    public SoundSpecifier TeleportSound = new SoundPathSpecifier("/Audio/Effects/teleport_arrival.ogg");
}
