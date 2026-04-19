// SPDX-FileCopyrightText: 2021 Vera Aguilera Puerto <6766154+Zumorica@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Kevin Zheng <kevinz5000@gmail.com>
// SPDX-FileCopyrightText: 2022 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Server.Atmos.Piping.Binary.Components;

/// <summary>
/// Defines a passive gate, which equalizes gas from
/// inlet to outlet, but does not allow gas to flow from outlet to inlet.
/// </summary>
[RegisterComponent]
public sealed partial class GasPassiveGateComponent : Component
{
    [DataField("inlet")]
    public string InletName = "inlet";

    [DataField("outlet")]
    public string OutletName = "outlet";

    [ViewVariables(VVAccess.ReadOnly)]
    [DataField]
    public float FlowRate;
}
