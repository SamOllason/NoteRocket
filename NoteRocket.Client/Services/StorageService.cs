using NoteRocket.Client.Models;

namespace NoteRocket.Client.Services;

public class StorageService : IStorageService
{
    public List<Note> Notes { get; set; }

    public StorageService()
    {
        Notes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal},
            new Note {  Id = 2, Title = "Learning list", Body = "C#", Category = Category.Learning },
            new Note {  Id = 3, Title = "Holiday plans for Spain", Body = "Madrid ...", Category = Category.Personal },
            new Note {  Id = 4, Title = "Dog walks around Bath", Body = "Map link here...", Category = Category.Personal },
        };
    }
}
