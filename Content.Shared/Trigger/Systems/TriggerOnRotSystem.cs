// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 blueDev2 <89804215+blueDev2@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Atmos.Rotting;
using Content.Shared.Trigger.Components.Triggers;

namespace Content.Shared.Trigger.Systems;

public sealed partial class TriggerOnRotSystem : TriggerOnXSystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<TriggerOnRotComponent, BeginRottingEvent>(OnRot);
    }

    private void OnRot(Entity<TriggerOnRotComponent> ent, ref BeginRottingEvent args)
    {
        Trigger.Trigger(ent.Owner, null, ent.Comp.KeyOut, predicted: false);
    }
}
