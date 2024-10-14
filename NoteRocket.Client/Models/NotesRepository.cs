namespace NoteRocket.Client.Models;

public class NotesRepository
{
    private static List<Note> notes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal},
            new Note {  Id = 2, Title = "Learning list", Body = "C#", Category = Category.Learning },
            new Note {  Id = 3, Title = "Holidays", Body = "Spain, France", Category = Category.Personal },
            new Note {  Id = 4, Title = "Dog walks", Body = "Map link here...", Category = Category.Random },
        };

         public static List<Note> GetNotes() => notes;
}



