namespace NoteRocket.Client.Models;

public class NotesRepository
{
    private static List<Note> notes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Shopping list", Body = "carrot, broccoli..." },
            new Note {  Id = 2, Title = "Learning list", Body = "C#" },
            new Note {  Id = 3, Title = "Holidays", Body = "Spain, France" },
        };

         public static List<Note> GetNotes() => notes;
}



