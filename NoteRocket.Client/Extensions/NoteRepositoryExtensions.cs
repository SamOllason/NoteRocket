using NoteRocket.Client.Models;
using NoteRocket.Client.Pages;
using NoteRocket.Client.Services;

namespace NoteRocket.Client.Extensions;

public static class NoteRepositoryExtensions
{
	public static Note UpdateNoteById(this NotesService notesRepository, int noteId, Note submittedNote, List<NotesHome> notes)
	{
		return submittedNote;
	}
}
