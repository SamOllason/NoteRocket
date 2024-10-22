namespace NoteRocket.Client.Models;

public interface INotesService
{
	List<Note> Notes { get; set; }
	List<Note> GetNotes();
	Note? GetNoteById(int noteId);
	void UpdateNote(int noteId, Note submittedNote);

}