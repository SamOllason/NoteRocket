using NoteRocket.Client.Models;

namespace NoteRocket.Client.Services;

public class NotesService : INotesService
{
    public List<Note> Notes { get; set; }

    public NotesService()
    {
        Notes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal},
            new Note {  Id = 2, Title = "Learning list", Body = "C#", Category = Category.Learning },
            new Note {  Id = 3, Title = "Holiday plans for Spain", Body = "Madrid ...", Category = Category.Personal },
            new Note {  Id = 4, Title = "Dog walks around Bath", Body = "Map link here...", Category = Category.Personal },
        };
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



