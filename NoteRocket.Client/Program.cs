using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NoteRocket.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IStorageService, StorageService>();
// We register our INotesService interface into our DI container and ask the container to give us an instance of the NotesService class whenever we request an INotesService.
builder.Services.AddSingleton<INotesService, NotesService>();

await builder.Build().RunAsync();
