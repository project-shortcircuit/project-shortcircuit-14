// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 blueDev2 <89804215+blueDev2@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.Atmos.Rotting;

/// <summary>
/// Raised when an entity starts to rot.
/// </summary>
[ByRefEvent]
public record struct BeginRottingEvent;
