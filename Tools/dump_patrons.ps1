# SPDX-FileCopyrightText: 2025 PJB3005 <pieterjan.briers+git@gmail.com>
# SPDX-FileCopyrightText: 2025 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
# SPDX-FileCopyrightText: 2025 Vasilis The Pikachu <vasilis@pikachu.systems>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

#!/usr/bin/env pwsh

param([string]$csvPath)

# Dumps Patreon's CSV download into a YAML file the game reads.

# Have to trim patron names because apparently Patreon doesn't which is quite ridiculous.
Get-content $csvPath | ConvertFrom-Csv -Delimiter "," | select @{l="Name";e={$_.Name.Trim()}},Tier | where-object Tier -ne "" | where-object Tier -ne "Free" | ConvertTo-Yaml
