// SPDX-FileCopyrightText: 2024 Ed <96445749+TheShuEd@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Shegare <147345753+Shegare@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.NPC.Systems;

public abstract partial class SharedNPCSystem : EntitySystem
{
    /// <summary>
    /// Returns whether the given entity is an NPC.
    /// </summary>
    /// <param name="uid">Entity UID to check.</param>
    /// <returns><c>true</c> if the entity is an NPC, otherwise <c>false</c>.</returns>
    public abstract bool IsNpc(EntityUid uid);
}
