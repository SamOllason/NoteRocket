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

    public int AddNote()
    {
        if (Notes.Count > 0)
        {
            var maxId = Notes.Max(n => n.Id);
            var newNoteId = maxId + 1;

            Notes.Add(new Note { Id = newNoteId, Title = "New note", Body = "..." });

            return newNoteId;
        }
        else
        {
            Notes.Add(new Note { Id = 0, Title = "New note", Body = "..." });
            return 0;
        }
    }
}



