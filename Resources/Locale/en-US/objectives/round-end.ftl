# SPDX-FileCopyrightText: 2023 deltanedas <@deltanedas:kde.org>
# SPDX-FileCopyrightText: 2023 themias <89101928+themias@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 deltanedas <39013340+deltanedas@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 ScarKy0 <106310278+ScarKy0@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

objectives-round-end-result = {$count ->
    [one] There was one {$agent}.
    *[other] There were {$count} {MAKEPLURAL($agent)}.
}

objectives-round-end-result-in-custody = {$custody} out of {$count} {MAKEPLURAL($agent)} were in custody.

objectives-player-user-named = [color=White]{$name}[/color] ([color=gray]{$user}[/color])
objectives-player-named = [color=White]{$name}[/color]

objectives-no-objectives = {$custody}{$title} was a {$agent}.
objectives-with-objectives = {$custody}{$title} was a {$agent} who had the following objectives:

objectives-objective-success = {$objective} | [color=green]Success![/color] ({TOSTRING($progress, "P0")})
objectives-objective-partial-success = {$objective} | [color=yellow]Partial Success![/color] ({TOSTRING($progress, "P0")})
objectives-objective-partial-failure = {$objective} | [color=orange]Partial Failure![/color] ({TOSTRING($progress, "P0")})
objectives-objective-fail = {$objective} | [color=red]Failure![/color] ({TOSTRING($progress, "P0")})

objectives-in-custody = [bold][color=red]| IN CUSTODY | [/color][/bold]
