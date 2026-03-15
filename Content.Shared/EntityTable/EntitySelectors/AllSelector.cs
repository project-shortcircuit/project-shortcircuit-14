// SPDX-FileCopyrightText: 2025 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using System.Linq;
using Robust.Shared.Prototypes;

namespace Content.Shared.EntityTable.EntitySelectors;

/// <summary>
/// Gets spawns from all of the child selectors
/// </summary>
public sealed partial class AllSelector : EntityTableSelector
{
    [DataField(required: true)]
    public List<EntityTableSelector> Children;

    protected override IEnumerable<EntProtoId> GetSpawnsImplementation(System.Random rand,
        IEntityManager entMan,
        IPrototypeManager proto,
        EntityTableContext ctx)
    {
        foreach (var child in Children)
        {
            foreach (var spawn in child.GetSpawns(rand, entMan, proto, ctx))
            {
                yield return spawn;
            }
        }
    }

    protected override IEnumerable<(EntProtoId spawn, double)> ListSpawnsImplementation(IEntityManager entMan, IPrototypeManager proto, EntityTableContext ctx)
    {
        foreach (var child in Children)
        {
            foreach (var (spawn, prob) in child.ListSpawns(entMan, proto, ctx))
            {
                yield return (spawn, prob);
            }
        }
    }

    protected override IEnumerable<(EntProtoId spawn, double)> AverageSpawnsImplementation(IEntityManager entMan, IPrototypeManager proto, EntityTableContext ctx)
    {
        foreach (var child in Children)
        {
            foreach (var (spawn, prob) in child.AverageSpawns(entMan, proto, ctx))
            {
                yield return (spawn, prob);
            }
        }
    }
}
