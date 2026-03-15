// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.FixedPoint;
using Robust.Shared.Serialization;

namespace Content.Shared.Chemistry
{
    /// <summary>
    /// Sent by the client when setting the transfer amount using the BUI.
    /// </summary>
    [Serializable, NetSerializable]
    public sealed class TransferAmountSetValueMessage(FixedPoint2 value) : BoundUserInterfaceMessage
    {
        /// <summary>
        /// The new transfer amount.
        /// </summary>
        public FixedPoint2 Value = value;
    }

    [Serializable, NetSerializable]
    public enum TransferAmountUiKey
    {
        Key,
    }
}
