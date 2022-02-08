using Proje.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.BAL.Abstract
{
    public interface IAppRoleService : IValidator<AppRole>
    {
        Task<AppRole> GetByIdAsync(int id);
        Task<AppRole> GetOneAsync(Expression<Func<AppRole, bool>> filter);
        Task<List<AppRole>> GetAllAsync(Expression<Func<AppRole, bool>> filter = null);
        Task<int> CreateAsync(AppRole entity);
        Task<int> UpdateAsync(AppRole entity);
        Task<int> DeleteAsync(AppRole entity);
        Task<int> CountAllasync(Expression<Func<AppRole, bool>> filter = null);
    }
}
