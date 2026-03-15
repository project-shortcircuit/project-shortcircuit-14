# SPDX-FileCopyrightText: 2021 20kdc <asdd2808@gmail.com>
# SPDX-FileCopyrightText: 2021 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 PJB3005 <pieterjan.briers+git@gmail.com>
# SPDX-FileCopyrightText: 2025 Vasilis The Pikachu <vasilis@pikachu.systems>
# SPDX-FileCopyrightText: 2025 opl- <opl-@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

#!/usr/bin/env bash

# Add this to .git/config:
# [merge "mapping-merge-driver"]
#         name = Merge driver for maps
#         driver = Tools/mapping-merge-driver.sh %A %O %B

dotnet run --project ./Content.Tools "$@"

