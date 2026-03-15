# SPDX-FileCopyrightText: 2021 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
# SPDX-FileCopyrightText: 2021 Galactic Chimp <63882831+GalacticChimp@users.noreply.github.com>
# SPDX-FileCopyrightText: 2021 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
# SPDX-FileCopyrightText: 2021 Remie Richards <remierichards@gmail.com>
# SPDX-FileCopyrightText: 2024 Alpha-Two <92269094+Alpha-Two@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 Alpha-Two <alpha2.5232@gmail.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

### UI

# Displayed in the Character prefs window
humanoid-character-profile-summary = 
    This is {$name}. {$gender ->
    [male] He is
    [female] She is
    [epicene] They are
    *[other] It is
} {$age} years old.