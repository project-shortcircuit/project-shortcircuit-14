// SPDX-FileCopyrightText: 2025 Samuka <47865393+Samuka-C@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Errant <35878406+Errant-4@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Server.Antag.Components;
using Robust.Shared.Random;

namespace Content.Server.Antag;

public sealed class AntagMultipleRoleSpawnerSystem : EntitySystem
{
    [Dependency] private readonly IRobustRandom _random = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AntagMultipleRoleSpawnerComponent, AntagSelectEntityEvent>(OnSelectEntity);
    }

    private void OnSelectEntity(Entity<AntagMultipleRoleSpawnerComponent> ent, ref AntagSelectEntityEvent args)
    {
        var entProtos = ent.Comp.AntagRoleToPrototypes[args.Antag];

        if (entProtos.Count == 0)
            return; // You will just get a normal job

        // TODO: Could probably turn this into a dictionary that takes an antag prototype and spits out an entity?
        args.Entity = Spawn(ent.Comp.PickAndTake ? _random.PickAndTake(entProtos) : _random.Pick(entProtos), args.Coords);
    }
}
