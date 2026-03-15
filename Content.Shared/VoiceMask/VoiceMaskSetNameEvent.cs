// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 beck-thompson <107373427+beck-thompson@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Leah <leahcatdev@gmail.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Actions;
using Content.Shared.Inventory;

namespace Content.Shared.VoiceMask;

public sealed partial class VoiceMaskSetNameEvent : InstantActionEvent
{
}

/// <summary>
/// Raised on an entity when their voice masks name is updated
/// </summary>
/// <param name="VoiceMask">VoiceMask component</param>
/// <param name="OldName">The old name</param>
/// <param name="NewName">The new name</param>
[ByRefEvent]
public readonly record struct VoiceMaskNameUpdatedEvent(Entity<VoiceMaskComponent> VoiceMask, string? OldName, string NewName) : IInventoryRelayEvent
{
    SlotFlags IInventoryRelayEvent.TargetSlots => SlotFlags.WITHOUT_POCKET;
}
