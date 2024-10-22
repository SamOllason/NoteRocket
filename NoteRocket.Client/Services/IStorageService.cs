using NoteRocket.Client.Models;

namespace NoteRocket.Client.Services;

public interface IStorageService
{
    public List<Note> Notes { get; set; }
}
