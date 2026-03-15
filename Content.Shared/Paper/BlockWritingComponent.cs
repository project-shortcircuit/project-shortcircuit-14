// SPDX-FileCopyrightText: 2025 Simon <63975668+Simyon264@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 SpeltIncorrectyl <66873282+SpeltIncorrectyl@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.GameStates;

namespace Content.Shared.Paper;

/// <summary>
/// An entity with this component cannot write on paper.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class BlockWritingComponent : Component
{
    /// <summary>
    /// What message is displayed when the entity fails to write?
    /// </summary>
    [DataField]
    [AutoNetworkedField]
    public LocId FailWriteMessage = "paper-component-illiterate";
}
