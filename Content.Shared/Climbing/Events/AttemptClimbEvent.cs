// SPDX-FileCopyrightText: 2024 Tayrtahn <tayrtahn@gmail.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.Climbing.Events;

[ByRefEvent]
public record struct AttemptClimbEvent(EntityUid User, EntityUid Climber, EntityUid Climbable)
{
    public bool Cancelled;
}
