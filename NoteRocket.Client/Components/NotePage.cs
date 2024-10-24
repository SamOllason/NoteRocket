﻿using Microsoft.AspNetCore.Components;
using NoteRocket.Client.Models;
using NoteRocket.Client.Services;

namespace NoteRocket.Client.Components;

public partial class NotePage : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    [Inject] public required INotesService NotesService { get; set; }
    [Inject] public required NavigationManager NavigationManager { get; set; }

    // note: this needs to be a property in order to
    // submit it back to the server after form submission
    [SupplyParameterFromForm(FormName = "formNotePage")]
    private Note? note { get; set; }

    protected override void OnParametersSet()
    {
        // only retrieve data from the repo if note is null
        // otherwise this will overwrite the data submitted in the form!
        note ??= NotesService.GetNoteById(Id);
    }
    private void Submit()
    {
        NotesService.UpdateNote(Id, note);
        NavigationManager.NavigateTo("/notes");
    }
};
