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
        var maxId = Notes.Max(n => n.Id);
        var maxItem = Notes.Where(n => n.Id == maxId).ToList().FirstOrDefault();

        var newNoteId = maxId++;

        if (maxItem is not null)
        {
            Notes.Add(new Note { Id = newNoteId, Title = "New note", Body = "..." });
        }

        return newNoteId;
    }
}



