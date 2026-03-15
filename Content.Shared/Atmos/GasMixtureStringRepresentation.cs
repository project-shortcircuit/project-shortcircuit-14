// SPDX-FileCopyrightText: 2023 Chief-Engineer <119664036+Chief-Engineer@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2026 ArtisticRoomba <145879011+ArtisticRoomba@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
//
// SPDX-License-Identifier: MIT

using System.Text;

namespace Content.Shared.Atmos;

public readonly record struct GasMixtureStringRepresentation(float TotalMoles, float Temperature, float Pressure, Dictionary<string, float> MolesPerGas) : IFormattable
{
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var (gas, moles) in MolesPerGas)
        {
            stringBuilder.Append($"{gas}: {moles}, ");
        }
        var result = stringBuilder.ToString();

        return $"{Temperature} K, {Pressure} kPa, {result}Total Moles: {TotalMoles}";
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return ToString();
    }

    public static implicit operator string(GasMixtureStringRepresentation rep) => rep.ToString();
}
