using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
    Task<T> GetOneAsync(Expression<Func<T, bool>> filter);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
    Task<int> CreateAsync(T entity);
    Task<int> UpdateAsync(T entity);
    Task<int> DeleteAsync(T entity);
    Task<int> CountAllasync(Expression<Func<T, bool>> filter = null);
}
}
