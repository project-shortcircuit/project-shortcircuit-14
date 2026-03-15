# SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 PJB3005 <pieterjan.briers+git@gmail.com>
# SPDX-FileCopyrightText: 2025 Princess Cheeseballs <66055347+Princess-Cheeseballs@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 Vasilis The Pikachu <vasilis@pikachu.systems>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

health-change-display =
    { $deltasign ->
        [-1] [color=green]{NATURALFIXED($amount, 2)}[/color] {$kind}
        *[1] [color=red]{NATURALFIXED($amount, 2)}[/color] {$kind}
    }
