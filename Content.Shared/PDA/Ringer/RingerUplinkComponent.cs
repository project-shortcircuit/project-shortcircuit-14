// SPDX-FileCopyrightText: 2025 Milon <milonpl.git@proton.me>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 SlamBamActionman <83650252+SlamBamActionman@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.GameStates;

namespace Content.Shared.PDA.Ringer;

/// <summary>
/// Makes a PDA able to open store UIs when the ringtone is set to a secret code.
/// Traitors are told the code when greeted.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(SharedRingerSystem))]
public sealed partial class RingerUplinkComponent : Component
{
    /// <summary>
    /// Whether to show the toggle uplink button in PDA settings.
    /// </summary>
    [DataField]
    public bool Unlocked;
}
