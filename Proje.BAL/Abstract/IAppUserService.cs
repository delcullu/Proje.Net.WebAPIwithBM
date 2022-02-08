
using Proje.Entities.Identity;
using System.Linq.Expressions;

namespace Proje.BAL.Abstract
{
    public interface IAppUserService : IValidator<AppUser>
    {
        Task<AppUser> GetByIdAsync(int id);
        Task<AppUser> GetOneAsync(Expression<Func<AppUser, bool>> filter);
        Task<List<AppUser>> GetAllAsync(Expression<Func<AppUser, bool>> filter = null);
        Task<int> CreateAsync(AppUser entity);
        Task<int> UpdateAsync(AppUser entity);
        Task<int> DeleteAsync(AppUser entity);
        Task<int> CountAllasync(Expression<Func<AppUser, bool>> filter = null);
    }
}
