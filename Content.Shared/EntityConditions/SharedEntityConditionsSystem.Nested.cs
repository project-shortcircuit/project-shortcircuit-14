// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 deltanedas <39013340+deltanedas@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Prototypes;

namespace Content.Shared.EntityConditions;

/// <summary>
/// Entity condition API counterpart using <see cref="EntityConditionPrototype"/> instead of <see cref="EntityCondition"/>.
/// </summary>
public sealed partial class SharedEntityConditionsSystem
{
    [Dependency] private readonly IPrototypeManager _proto = default!;

    /// <summary>
    /// <c>TryCondition</c> overload that uses a <see cref="EntityConditionPrototype"/> instead of <see cref="EntityCondition"/>.
    /// </summary>
    public bool TryCondition(EntityUid target, [ForbidLiteral] ProtoId<EntityConditionPrototype> id)
    {
        var proto = _proto.Index(id);
        return TryCondition(target, proto.Condition);
    }
}
