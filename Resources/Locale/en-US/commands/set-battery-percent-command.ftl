# SPDX-FileCopyrightText: 2025 Kyle Tyo <36606155+VerinSenpai@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

cmd-setbatterypercent-desc = Drains or recharges a battery by entity uid and percentage, i.e.: forall with Battery do setbatterypercent $ID 0
cmd-setbatterypercent-help = Usage: setbatterypercent <id> <percent>
cmd-setbatterypercent-battery-not-found = No battery found with id {$id}.
cmd-setbatterypercent-not-valid-percent = {$arg} is not a valid float (percentage).
