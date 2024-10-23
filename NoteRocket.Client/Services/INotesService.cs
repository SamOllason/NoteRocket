using NoteRocket.Client.Models;

namespace NoteRocket.Client.Services;

public interface INotesService
{
    List<Note> Notes { get; set; }
    List<Note> GetNotes();
    Note? GetNoteById(int noteId);
    void UpdateNote(int noteId, Note submittedNote);
    int AddNote();

}