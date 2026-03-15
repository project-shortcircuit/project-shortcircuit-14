// SPDX-FileCopyrightText: 2025 PJB3005 <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2025 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Vasilis The Pikachu <vasilis@pikachu.systems>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 pathetic meowmeow <uhhadd@gmail.com>
//
// SPDX-License-Identifier: MIT

using System.Linq;
using Content.Shared.Localizations;
using Content.Shared.Metabolism;
using Robust.Shared.Prototypes;

namespace Content.Shared.EntityConditions.Conditions.Body;

/// <inheritdoc cref="EntityCondition"/>
public sealed partial class MetabolizerTypeCondition : EntityConditionBase<MetabolizerTypeCondition>
{
    [DataField(required: true)]
    public ProtoId<MetabolizerTypePrototype>[] Type = default!;

    public override string EntityConditionGuidebookText(IPrototypeManager prototype)
    {
        var typeList = new List<string>();

        foreach (var type in Type)
        {
            if (!prototype.Resolve(type, out var proto))
                continue;

            typeList.Add(proto.LocalizedName);
        }

        var names = ContentLocalizationManager.FormatListToOr(typeList);

        return Loc.GetString("entity-condition-guidebook-organ-type",
            ("name", names),
            ("shouldhave", !Inverted));
    }
}

/// <summary>
/// Returns true if this entity has any of the listed metabolizer types.
/// </summary>
/// <inheritdoc cref="EntityConditionSystem{T, TCondition}"/>
public sealed partial class MetabolizerTypeEntityConditionSystem : EntityConditionSystem<MetabolizerComponent, MetabolizerTypeCondition>
{
    protected override void Condition(Entity<MetabolizerComponent> entity, ref EntityConditionEvent<MetabolizerTypeCondition> args)
    {
        if (entity.Comp.MetabolizerTypes == null)
            return;

        args.Result = entity.Comp.MetabolizerTypes.Overlaps(args.Condition.Type);
    }
}
