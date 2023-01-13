using Afy.Library.WebUI.Models.Library;

namespace Afy.Library.WebUI.Interfaces.Services
{
    public interface ILibraryItemService
    {
        Task<IEnumerable<LibraryItem>> GetsAsync();
        Task<IEnumerable<LibraryItem>> GetFoldersAsync();
        Task Add(LibraryItem model);
    }
}
