using Microsoft.AspNetCore.Components;
using NoteRocket.Client.Models;
using NoteRocket.Client.Services;

namespace NoteRocket.Client.Pages;

public partial class NotesHome : ComponentBase
{
    private List<Note>? Notes { get; set; }

    [Inject] public required INotesService NotesService { get; set; }
    [Inject] public required NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        // only retrieve data from the repo if Notes is not null
        // to avoid overwriting (TODO: is this needed?)
        Notes ??= NotesService.GetNotes();
    }
    private void AddNote()
    {
        // add new note with default title
        // navigate user to that new note
        // call NotesService.GetNotes(); to get latest notes

        Console.WriteLine("AddNote");
        var newNoteId = NotesService.AddNote();
        Console.WriteLine(newNoteId);

        //should this be in another lifecycle method? when params update?
        Notes = NotesService.GetNotes();

        NavigationManager.NavigateTo($"/notes/edit/{newNoteId}");
    }
}
