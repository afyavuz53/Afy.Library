using Afy.Library.WebUI.Interfaces.Repositories;
using Afy.Library.WebUI.Interfaces.Services;
using Afy.Library.WebUI.Models.Library;
using Afy.Library.WebUI.Repositories;
using Afy.Library.WebUI.Services;

namespace Afy.Library.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddAplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IReadRepository<LibraryItem>, ReadRepository<LibraryItem>>();
            services.AddScoped<IWriteRepository<LibraryItem>, WriteRepository<LibraryItem>>();

            services.AddScoped<ILibraryItemService, LibraryItemService>();
        }
    }
}
