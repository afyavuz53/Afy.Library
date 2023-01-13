using System.Linq.Expressions;

namespace Afy.Library.WebUI.Interfaces.Repositories
{
    public interface IReadRepository<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter);
        Task<T?> GetAsync(string id);
    }
}
