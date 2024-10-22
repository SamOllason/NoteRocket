using NoteRocket.Client.Models;

namespace NoteRocket.Client.Services;

public class NotesService : INotesService
{
    public List<Note> Notes { get; set; }

    public NotesService(IStorageService storageService)
    {
        Notes = storageService.Notes;
    }

    public List<Note> GetNotes() => Notes;

    public Note? GetNoteById(int noteId)
    {
        return Notes.FirstOrDefault(n => n.Id == noteId);
    }

    public void UpdateNote(int noteId, Note submittedNote)
    {
        if (noteId != submittedNote.Id)
            return;

        var noteToUpdate = Notes.FirstOrDefault(n => n.Id == noteId);
        if (noteToUpdate is not null)
        {
            noteToUpdate.Title = submittedNote.Title;
            noteToUpdate.Body = submittedNote.Body;
        }

    }
}



