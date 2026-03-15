// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Administration.BanList;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Administration.UI.BanList;

public interface IBanListLine<T> where T : SharedBan
{
    T Ban { get; }
    Label Reason { get; }
    Label BanTime { get; }
    Label Expires { get; }
    Label BanningAdmin { get; }
}
