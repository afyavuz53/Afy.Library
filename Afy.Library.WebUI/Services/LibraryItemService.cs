using Afy.Library.WebUI.Interfaces.Repositories;
using Afy.Library.WebUI.Interfaces.Services;
using Afy.Library.WebUI.Models.Library;

namespace Afy.Library.WebUI.Services
{
    internal class LibraryItemService : ILibraryItemService
    {
        private readonly IReadRepository<LibraryItem> _readRepository;
        private readonly IWriteRepository<LibraryItem> _writeRepository;
        public LibraryItemService(IReadRepository<LibraryItem> readRepository, IWriteRepository<LibraryItem> writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task<IEnumerable<LibraryItem>> GetsAsync()
        {
            return await _readRepository.GetAsync();
        }

        public async Task<IEnumerable<LibraryItem>> GetFoldersAsync()
        {
            return await _readRepository.GetAsync(x => x.IsFolder);
        }

        public async Task Add(LibraryItem model)
        {
            await _writeRepository.CreateAsync(model);
        }
    }
}
