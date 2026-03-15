# SPDX-FileCopyrightText: 2025 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

-damage-popup-component-type =
    { $setting ->
        [combined] Combined
        [total] Total
        [delta] Delta
        [hit] Hit
       *[other] Unknown
    }

damage-popup-component-switched = Target set to type: { -damage-popup-component-type(setting: $setting) }