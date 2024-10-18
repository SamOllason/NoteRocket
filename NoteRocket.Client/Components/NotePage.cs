﻿using Microsoft.AspNetCore.Components;
using NoteRocket.Client.Models;

namespace NoteRocket.Client.Components;

public partial class NotePage : ComponentBase
{
    // private Note note = new Note { Title = "Title 1", Body = "<b>NoteBody<b>" };

    [Parameter]
    public int Id { get; set; }

    private Note? note;

    protected override void OnParametersSet()
    {
        note = NotesRepository.GetNoteById(Id);
    }
};
