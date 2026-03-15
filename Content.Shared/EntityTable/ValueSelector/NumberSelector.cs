// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ArtisticRoomba <145879011+ArtisticRoomba@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.EntityTable.EntitySelectors;
using JetBrains.Annotations;

namespace Content.Shared.EntityTable.ValueSelector;

/// <summary>
/// Used for implementing custom value selection for <see cref="EntityTableSelector"/>
/// </summary>
[ImplicitDataDefinitionForInheritors, UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public abstract partial class NumberSelector
{
    public abstract int Get(System.Random rand);

    /// <summary>
    /// Odds of occurrence
    /// </summary>
    /// <returns>An odds multiplier of at least one occurrence</returns>
    public abstract float Odds();

    /// <summary>
    /// Average number of occurrences
    /// </summary>
    /// <returns>The average amount of occurrences</returns>
    public abstract float Average();
}
