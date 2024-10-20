﻿using Microsoft.AspNetCore.Components;
using NoteRocket.Client.Models;

namespace NoteRocket.Client.Components;

public partial class NotePage : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    // note: this needs to be a property in order to
    // submit it back to the server after form submission
    [SupplyParameterFromForm(FormName = "formNotePage")]
    private Note? note { get; set; }

    protected override void OnParametersSet()
    {
        // only retrieve data from the repo if note is null
        // otherwise this will overwrite the form submissions!
        note ??= NotesRepository.GetNoteById(Id);
    }
    private void Submit()
    {
        Console.WriteLine("Submit");
        //NotesRepository.UpdateNote(id, note);
    }

};
