// SPDX-FileCopyrightText: 2022 Flipp Syder <76629141+vulppine@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 TemporalOroboros <TemporalOroboros@gmail.com>
// SPDX-FileCopyrightText: 2024 Ed <96445749+TheShuEd@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 B_Kirill <153602297+B-Kirill@users.noreply.github.com>
// SPDX-FileCopyrightText: 2026 Ilya Mikheev <me@ilyamikcoder.com>
// SPDX-FileCopyrightText: 2026 pathetic meowmeow <uhhadd@gmail.com>
//
// SPDX-License-Identifier: MIT

using Content.Client.Humanoid;
using Content.Shared.MagicMirror;
using Robust.Client.UserInterface;

namespace Content.Client.MagicMirror;

public sealed class MagicMirrorBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private MagicMirrorWindow? _window;

    private readonly MarkingsViewModel _markingsModel = new();

    public MagicMirrorBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<MagicMirrorWindow>();

        _window.Title = EntMan.GetComponent<MetaDataComponent>(Owner).EntityName;

        _window.MarkingsPicker.SetModel(_markingsModel);

        _markingsModel.MarkingsChanged += (_, _) =>
        {
            SendMessage(new MagicMirrorSelectMessage(_markingsModel.Markings));
        };
    }

    protected override void UpdateState(BoundUserInterfaceState state)
    {
        base.UpdateState(state);

        if (state is not MagicMirrorUiState data)
            return;

        _markingsModel.OrganData = data.OrganMarkingData;
        _markingsModel.OrganProfileData = data.OrganProfileData;
        _markingsModel.Markings = data.AppliedMarkings;
    }
}

