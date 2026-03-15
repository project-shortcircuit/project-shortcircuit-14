// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Samuka <47865393+Samuka-C@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Server.Power.Components;
using Content.Shared.Power.Components;

namespace Content.Server.Power.EntitySystems;

public sealed class PowerConsumerBatteryChargerSystem : EntitySystem
{
    [Dependency] private readonly BatterySystem _battery = default!;

    public override void Update(float frameTime)
    {
        var query = EntityQueryEnumerator<PowerConsumerBatteryChargerComponent, PowerConsumerComponent, BatteryComponent, TransformComponent>();

        while (query.MoveNext(out var entity, out _, out var powerConsumerComp, out var battery, out var transform))
        {
            if (!transform.Anchored)
                continue;

            _battery.ChangeCharge((entity, battery), powerConsumerComp.NetworkLoad.ReceivingPower * frameTime);
        }
    }
}
