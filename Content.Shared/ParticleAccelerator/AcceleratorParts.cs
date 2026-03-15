// SPDX-FileCopyrightText: 2025 BarryNorfolk <barrynorfolkman@protonmail.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Serialization;

namespace Content.Shared.ParticleAccelerator;

[Serializable, NetSerializable]
public enum AcceleratorParts : byte
{
    EndCap,
    FuelChamber,
    PowerBox,
    PortEmitter,
    ForeEmitter,
    StarboardEmitter
};


