// SPDX-FileCopyrightText: 2026 ArtisticRoomba <145879011+ArtisticRoomba@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Content.Server.Power.Components;
using Content.Shared.Power.Components;
using Content.Shared.Power.EntitySystems;

namespace Content.Server.Power.EntitySystems;

public sealed class PowerStateSystem : SharedPowerStateSystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PowerStateComponent, ComponentStartup>(OnComponentStartup);
    }

    private void OnComponentStartup(Entity<PowerStateComponent> ent, ref ComponentStartup args)
    {
        EnsureComp<ApcPowerReceiverComponent>(ent);
        SetWorkingState(ent.Owner, ent.Comp.IsWorking);
    }
}
