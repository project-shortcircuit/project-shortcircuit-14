// SPDX-FileCopyrightText: 2021 Flipp Syder <76629141+vulppine@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 c4llv07e <38111072+c4llv07e@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
namespace Content.Shared.SubFloor;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class TrayScannerComponent : Component
{
    /// <summary>
    ///     Whether the scanner is currently on.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Enabled;

    /// <summary>
    ///     Current mode of operation, defines which subfloor entities are shown.
    /// </summary>
    [DataField, AutoNetworkedField]
    public TrayScannerMode Mode = TrayScannerMode.All;

    /// <summary>
    ///     Radius in which the scanner will reveal entities. Centered on the <see cref="LastLocation"/>.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float Range = 4f;

    [DataField]
    public SoundSpecifier SoundSwitchMode = new SoundPathSpecifier("/Audio/Machines/quickbeep.ogg");
}

[Serializable, NetSerializable]
public enum TrayScannerMode
{
    All,
    Piping,
    Wiring
}

[Serializable, NetSerializable]
public enum TrayScannerVisual : byte
{
    Visual,
    On,
    Off
}
