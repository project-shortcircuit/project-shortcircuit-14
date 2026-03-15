// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Shegare <147345753+Shegare@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Client.NPC.HTN;
using Content.Shared.NPC.Systems;

namespace Content.Client.NPC.Systems;

public sealed class NPCSystem : SharedNPCSystem
{
    public override bool IsNpc(EntityUid uid)
    {
        return HasComp<HTNComponent>(uid);
    }
}
