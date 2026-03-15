// SPDX-FileCopyrightText: 2022 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 InsoPL <lukasz.lindert@protonmail.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Sandbox
{
    public abstract class SharedSandboxSystem : EntitySystem
    {
        [Dependency] protected readonly IPrototypeManager PrototypeManager = default!;

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxStatus : EntityEventArgs
        {
            public bool SandboxAllowed { get; set; }
        }

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxRespawn : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxGiveAccess : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxGiveAghost : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxSuicide : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxThermalVision : EntityEventArgs {}
    }
}
