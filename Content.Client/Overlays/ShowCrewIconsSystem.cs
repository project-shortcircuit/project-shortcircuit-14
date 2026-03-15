// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 SlamBamActionman <83650252+SlamBamActionman@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Inventory.Events;
using Content.Shared.Overlays;

namespace Content.Client.Overlays;

// The GetStatusIconsEvent subscription is handled in JobStatusSystem
public sealed class ShowCrewIconsSystem : EquipmentHudSystem<ShowCrewIconsComponent>
{
    public bool UncertainCrewBorder = false;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<ShowCrewIconsComponent, AfterAutoHandleStateEvent>(OnHandleState);
    }

    protected override void UpdateInternal(RefreshEquipmentHudEvent<ShowCrewIconsComponent> component)
    {
        base.UpdateInternal(component);

        UncertainCrewBorder = false;
        foreach (var comp in component.Components)
        {
            if (comp.UncertainCrewBorder)
                UncertainCrewBorder = true;
        }
    }

    private void OnHandleState(Entity<ShowCrewIconsComponent> ent, ref AfterAutoHandleStateEvent args)
    {
        RefreshOverlay();
    }
}
