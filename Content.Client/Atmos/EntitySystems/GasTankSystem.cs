// SPDX-FileCopyrightText: 2025 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Atmos.Components;
using Content.Shared.Atmos.EntitySystems;

namespace Content.Client.Atmos.EntitySystems;

public sealed class GasTankSystem : SharedGasTankSystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<GasTankComponent, AfterAutoHandleStateEvent>(OnGasTankState);
    }

    protected override void DeviceUpdated(Entity<GasTankComponent> entity, ref AtmosDeviceUpdateEvent args)
    {
        // Atmos not predicted :(
        throw new NotImplementedException();
    }

    private void OnGasTankState(Entity<GasTankComponent> ent, ref AfterAutoHandleStateEvent args)
    {
        if (UI.TryGetOpenUi(ent.Owner, SharedGasTankUiKey.Key, out var bui))
        {
            bui.Update<GasTankBoundUserInterfaceState>();
        }
    }

    public override void UpdateUserInterface(Entity<GasTankComponent> ent)
    {
        if (UI.TryGetOpenUi(ent.Owner, SharedGasTankUiKey.Key, out var bui))
        {
            bui.Update<GasTankBoundUserInterfaceState>();
        }
    }
}
