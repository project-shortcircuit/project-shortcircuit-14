# SPDX-FileCopyrightText: 2025 Centronias <me@centronias.com>
# SPDX-FileCopyrightText: 2025 slarticodefast <161409025+slarticodefast@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
#
# SPDX-License-Identifier: MIT

parcel-wrap-verb-wrap = Wrap
parcel-wrap-verb-unwrap = Unwrap

parcel-wrap-popup-parcel-destroyed = The wrapping containing { THE($contents) } is destroyed!
parcel-wrap-popup-being-wrapped = {CAPITALIZE(THE($user))} is trying to parcel wrap you!
parcel-wrap-popup-being-wrapped-self = You start parcel wrapping yourself.

# Shown when parcel wrap is examined in details range
parcel-wrap-examine-detail-uses = { $uses ->
    [one] There is [color={$markupUsesColor}]{$uses}[/color] use left
    *[other] There are [color={$markupUsesColor}]{$uses}[/color] uses left
}.
