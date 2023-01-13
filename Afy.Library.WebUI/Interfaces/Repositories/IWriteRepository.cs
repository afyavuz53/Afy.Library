using Afy.Library.WebUI.Models;

namespace Afy.Library.WebUI.Interfaces.Repositories
{
    public interface IWriteRepository<T>
        where T : BaseEntity
    {
        Task CreateAsync(T newProduct);
        Task UpdateAsync(string id, T updatedProduct);
        Task RemoveAsync(string id);
    }
}
