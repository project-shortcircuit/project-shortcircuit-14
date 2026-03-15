// SPDX-FileCopyrightText: 2022 Emisse <99158783+Emisse@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2023 Ben <50087092+benev0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 BenOwnby <ownbyb@appstate.edu>
// SPDX-FileCopyrightText: 2023 Slava0135 <40753025+Slava0135@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Visne <39844191+Visne@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Kara <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2024 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2024 Plykiya <58439124+Plykiya@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 lzk <124214523+lzk228@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Tayrtahn <tayrtahn@gmail.com>
// SPDX-FileCopyrightText: 2025 TemporalOroboros <TemporalOroboros@gmail.com>
// SPDX-FileCopyrightText: 2025 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 TriviaSolari <154280615+TriviaSolari@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Examine;
using Content.Shared.Interaction;
using Content.Shared.PowerCell;
using Content.Shared.Storage;
using Robust.Shared.Network;

namespace Content.Shared.Holosign;

public sealed class HolosignSystem : EntitySystem
{
    [Dependency] private readonly PowerCellSystem _powerCell = default!;
    [Dependency] private readonly INetManager _net = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<HolosignProjectorComponent, BeforeRangedInteractEvent>(OnBeforeInteract);
        SubscribeLocalEvent<HolosignProjectorComponent, ExaminedEvent>(OnExamine);
    }

    private void OnExamine(Entity<HolosignProjectorComponent> ent, ref ExaminedEvent args)
    {
        // TODO: This should probably be using an itemstatus
        // TODO: I'm too lazy to do this rn but it's literally copy-paste from emag.
        var charges = _powerCell.GetRemainingUses(ent.Owner, ent.Comp.ChargeUse);
        var maxCharges = _powerCell.GetMaxUses(ent.Owner, ent.Comp.ChargeUse);

        using (args.PushGroup(nameof(HolosignProjectorComponent)))
        {
            args.PushMarkup(Loc.GetString("limited-charges-charges-remaining", ("charges", charges)));

            if (charges > 0 && charges == maxCharges)
            {
                args.PushMarkup(Loc.GetString("limited-charges-max-charges"));
            }
        }
    }

    private void OnBeforeInteract(Entity<HolosignProjectorComponent> ent, ref BeforeRangedInteractEvent args)
    {
        if (args.Handled
            || !args.CanReach // prevent placing out of range
            || HasComp<StorageComponent>(args.Target) // if it's a storage component like a bag, we ignore usage so it can be stored
            || !_powerCell.TryUseCharge(ent.Owner, ent.Comp.ChargeUse, user: args.User, predicted: true) // if no battery or no charge, doesn't work
            )
            return;

        // overlapping of the same holo on one tile remains allowed to allow holofan refreshes
        if (ent.Comp.PredictedSpawn || _net.IsServer)
        {
            var holosign = PredictedSpawnAtPosition(ent.Comp.SignProto, args.ClickLocation);
            Transform(holosign).LocalRotation = Angle.Zero;
        }

        args.Handled = true;
    }
}
