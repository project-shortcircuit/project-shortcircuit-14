// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared.Administration.BanList;

[Serializable, NetSerializable]
public sealed class BanListEuiState : EuiStateBase
{
    public BanListEuiState(string banListPlayerName, List<SharedBan> bans, List<SharedBan> roleBans)
    {
        BanListPlayerName = banListPlayerName;
        Bans = bans;
        RoleBans = roleBans;
    }

    public string BanListPlayerName { get; }
    public List<SharedBan> Bans { get; }
    public List<SharedBan> RoleBans { get; }
}
