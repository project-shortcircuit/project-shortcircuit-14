// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Atmos;

namespace Content.Shared.NodeContainer.NodeGroups;

public interface IPipeNet : INodeGroup, IGasMixtureHolder
{
    /// <summary>
    /// Causes gas in the PipeNet to react.
    /// </summary>
    void Update();
}
