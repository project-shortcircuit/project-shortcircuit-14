// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 csqrb <56765288+CaptainSqrBeard@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 pathetic meowmeow <uhhadd@gmail.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Shared.Humanoid.Markings.ColoringTypes;

/// <summary>
///     Colors layer in a specified color
/// </summary>
public sealed partial class SimpleColoring : LayerColoringType
{
    [DataField("color", required: true)]
    public Color Color = Color.White;

    public override Color? GetCleanColor(Color? skin, Color? eyes, List<Marking> otherMarkings)
    {
        return Color;
    }
}
