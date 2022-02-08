using Microsoft.EntityFrameworkCore;
using Proje.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Concrate
{
    public class EFCoreGenericRepository<T, TContext> : IRepository<T>
        where T : class
        where TContext : DbContext, new()
    {
        public async Task<int> CreateAsync(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                return await context.SaveChangesAsync();
            }
        }
        public async Task<int> DeleteAsync(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public async Task<T> GetOneAsync(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().Where(filter).FirstOrDefaultAsync();
            }
        }
        public async Task<int> UpdateAsync(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                return await context.SaveChangesAsync();

            }
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                         ? await context.Set<T>().AsNoTracking().ToListAsync()
                         : await context.Set<T>().Where(filter).AsNoTracking().ToListAsync();
            }
        }
        public async Task<int> CountAllasync(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                         ? await context.Set<T>().AsNoTracking().CountAsync()
                         : await context.Set<T>().Where(filter).AsNoTracking().CountAsync();
            }
        }
    }
}
