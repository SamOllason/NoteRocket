using Microsoft.AspNetCore.Components;
using NoteRocket.Client.Models;

namespace NoteRocket.Client.Pages;

public partial class NotesHome : ComponentBase
{
    private List<Note>? Notes { get; set; }

    [Inject] public required INotesService NotesService { get; set; }

    protected override void OnInitialized()
    {
        // only retrieve data from the repo if Notes is not null
        // to avoid overwriting the data submitted in the form!
        Notes ??= NotesService.GetNotes();
    }
}
