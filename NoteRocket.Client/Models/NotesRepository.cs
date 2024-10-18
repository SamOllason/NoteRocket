﻿namespace NoteRocket.Client.Models;

public class NotesRepository
{
    private static List<Note> notes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal},
            new Note {  Id = 2, Title = "Learning list", Body = "C#", Category = Category.Learning },
            new Note {  Id = 3, Title = "Holiday plans for Spain", Body = "Madrid ...", Category = Category.Personal },
            new Note {  Id = 4, Title = "Dog walks around Bath", Body = "Map link here...", Category = Category.Personal },
        };

    public static List<Note> GetNotes() => notes;
}



