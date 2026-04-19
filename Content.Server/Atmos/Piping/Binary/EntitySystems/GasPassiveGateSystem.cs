// SPDX-FileCopyrightText: 2021 20kdc <asdd2808@gmail.com>
// SPDX-FileCopyrightText: 2021 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2021 Vera Aguilera Puerto <6766154+Zumorica@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Visne <39844191+Visne@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Kara <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2023 faint <46868845+ficcialfaint@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Kevin Zheng <kevinz5000@gmail.com>
// SPDX-FileCopyrightText: 2024 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Server.Atmos.EntitySystems;
using Content.Server.Atmos.Piping.Binary.Components;
using Content.Server.NodeContainer.EntitySystems;
using Content.Server.NodeContainer.Nodes;
using Content.Shared.Atmos.Components;
using Content.Shared.Examine;
using JetBrains.Annotations;

namespace Content.Server.Atmos.Piping.Binary.EntitySystems;

[UsedImplicitly]
public sealed class GasPassiveGateSystem : EntitySystem
{
    [Dependency] private readonly AtmosphereSystem _atmosphereSystem = default!;
    [Dependency] private readonly NodeContainerSystem _nodeContainer = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<GasPassiveGateComponent, AtmosDeviceUpdateEvent>(OnPassiveGateUpdated);
        SubscribeLocalEvent<GasPassiveGateComponent, ExaminedEvent>(OnExamined);
    }

    private void OnPassiveGateUpdated(EntityUid uid, GasPassiveGateComponent gate, ref AtmosDeviceUpdateEvent args)
    {
        if (!_nodeContainer.TryGetNodes(uid, gate.InletName, gate.OutletName, out PipeNode? inlet, out PipeNode? outlet))
            return;

        // ReSharper disable thrice InconsistentNaming
        var P1 = inlet.Air.Pressure;
        var P2 = outlet.Air.Pressure;
        var V1 = inlet.Air.Volume;
        var pressureDelta = P1 - P2;

        var dt = args.dt;
        float dV = 0;
        if (pressureDelta > 0 && P1 > 0)
        {
            var transferFrac = _atmosphereSystem.FractionToEqualizePressure(inlet.Air, outlet.Air);
            dV = transferFrac * V1;

            // Actually transfer the gas.
            _atmosphereSystem.Merge(outlet.Air, inlet.Air.RemoveRatio(transferFrac));
        }

        gate.FlowRate = AtmosphereSystem.ExponentialMovingAverage(dV, gate.FlowRate, dt);
    }

    private void OnExamined(Entity<GasPassiveGateComponent> gate, ref ExaminedEvent args)
    {
        if (!Transform(gate).Anchored || !args.IsInDetailsRange) // Not anchored? Out of range? No status.
            return;

        var str = Loc.GetString("gas-passive-gate-examined", ("flowRate", $"{gate.Comp.FlowRate:0.#}"));
        args.PushMarkup(str);
    }
}
