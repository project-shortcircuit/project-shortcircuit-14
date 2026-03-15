// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
//
// SPDX-License-Identifier: MIT

using System.Collections.Immutable;
using Content.Shared.Database;
using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Shared.Administration.BanList;

[Serializable, NetSerializable]
public record SharedBan(
    int? Id,
    BanType Type,
    ImmutableArray<NetUserId> UserIds,
    ImmutableArray<(string address, int cidrMask)> Addresses,
    ImmutableArray<string> HWIds,
    DateTime BanTime,
    DateTime? ExpirationTime,
    string Reason,
    string? BanningAdminName,
    SharedUnban? Unban,
    ImmutableArray<BanRoleDef>? Roles);
