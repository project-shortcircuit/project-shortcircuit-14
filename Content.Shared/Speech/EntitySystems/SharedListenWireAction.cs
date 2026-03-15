// SPDX-FileCopyrightText: 2024 Tayrtahn <tayrtahn@gmail.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Serialization;

namespace Content.Shared.Speech;

[Serializable, NetSerializable]
public enum ListenWireActionKey : byte
{
    StatusKey,
    TimeoutKey,
}
