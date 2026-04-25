// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Antag;
using Robust.Shared.Prototypes;

/// <summary>
/// Ghost role spawner that creates an antag for the associated game rule.
/// </summary>
[RegisterComponent, Access(typeof(AntagSelectionSystem))]
public sealed partial class GhostRoleAntagSpawnerComponent : Component
{
    [DataField]
    public EntityUid? Rule;

    [DataField]
    public ProtoId<AntagSpecifierPrototype>? Definition;
}
