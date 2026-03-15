// SPDX-FileCopyrightText: 2024 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.Beeper;
[ByRefEvent]
public record struct BeepPlayedEvent(bool Muted);

