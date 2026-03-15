# SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
# SPDX-FileCopyrightText: 2026 ScarKy0 <106310278+ScarKy0@users.noreply.github.com>
# SPDX-FileCopyrightText: 2026 UpAndLeaves <92269094+Alpha-Two@users.noreply.github.com>
#
# SPDX-License-Identifier: MIT

command-description-inventory-getflags =
    Gets all entities in slots on the piped inventory entity matching a certain slot flag.
command-description-inventory-getnamed =
    Gets all entities in slots on the piped inventory entity matching a certain slot name.
command-description-inventory-forceput =
    Puts a given entity on the first piped entity that has a slot matching the given flag, deleting any item previously in that slot.
command-description-inventory-forcespawn =
    Spawns a given prototype on the first piped entity that has a slot matching the given flag, deleting any item previously in that slot.
command-description-inventory-put =
    Puts a given entity on the first piped entity that has a slot matching the given flag, unequiping any item previously in that slot.
command-description-inventory-spawn =
    Spawns a given prototype on the first piped entity that has a slot matching the given flag, unequiping any item previously in that slot.
command-description-inventory-tryput =
    Tries to put a given entity on the first piped entity that has a slot matching the given flag, failing if any item is in currently in that slot.
command-description-inventory-tryspawn =
    Tries to spawn a given prototype on the first piped entity that has a slot matching the given flag, failing if any item is in currently in that slot.
command-description-inventory-ensure =
    Puts a given entity on the first piped entity that has a slot matching the given flag if none exists, passing through the UID of whatever is in the slot by the end.
command-description-inventory-ensurespawn =
    Spawns a given prototype on the first piped entity that has a slot matching the given flag if none exists, passing through the UID of whatever is in the slot by the end.
command-description-inventory-query =
    Gets the entities in the inventory slots of the piped entities and passes them along.
