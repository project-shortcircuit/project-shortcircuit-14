// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 deltanedas <39013340+deltanedas@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Prototypes;

namespace Content.Shared.EntityConditions.Conditions;

/// <summary>
/// Uses the conditions of an <see cref="EntityConditionPrototype"/>.
/// </summary>
public sealed partial class NestedCondition : EntityConditionBase<NestedCondition>
{
    /// <summary>
    /// The condition prototype to use.
    /// </summary>
    [DataField(required: true)]
    public ProtoId<EntityConditionPrototype> Proto;

    public override string EntityConditionGuidebookText(IPrototypeManager prototype)
        => prototype.Index(Proto).Condition.EntityConditionGuidebookText(prototype);
}

/// <summary>
/// Handles <see cref="NestedCondition"/>.
/// </summary>
public sealed class NestedConditionSystem : EntityConditionSystem<TransformComponent, NestedCondition>
{
    [Dependency] private readonly SharedEntityConditionsSystem _conditions = default!;

    protected override void Condition(Entity<TransformComponent> ent, ref EntityConditionEvent<NestedCondition> args)
    {
        args.Result = _conditions.TryCondition(ent, args.Condition.Proto);
    }
}
