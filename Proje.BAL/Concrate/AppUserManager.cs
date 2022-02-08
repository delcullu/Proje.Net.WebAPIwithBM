using Proje.BAL.Abstract;
using Proje.DAL.Abstract;
using Proje.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.BAL.Concrate
{
    public class AppUserManager : IAppUserService
    {
        public IAppUserDAL _appUserDAL;

        public AppUserManager(IAppUserDAL customMenuDal)
        {
            _appUserDAL = customMenuDal;
        }
        public string ErrorMessage { get; set; }

        public async Task<int> CountAllasync(Expression<Func<AppUser, bool>> filter = null)
        {
            return await _appUserDAL.CountAllasync(filter);
        }

        public async Task<int> CreateAsync(AppUser entity)
        {
            if (Validate(entity))
            {
                return await _appUserDAL.CreateAsync(entity);
            }
            return 500;
        }

        public async Task<int> DeleteAsync(AppUser entity)
        {
            return await _appUserDAL.DeleteAsync(entity);
        }

        public async Task<List<AppUser>> GetAllAsync(Expression<Func<AppUser, bool>> filter = null)
        {
            return await _appUserDAL.GetAllAsync(filter);
        }

        public async Task<AppUser> GetByIdAsync(int id)
        {
            return await _appUserDAL.GetByIdAsync(id);
        }

        public async Task<AppUser> GetOneAsync(Expression<Func<AppUser, bool>> filter)
        {
            return await _appUserDAL.GetOneAsync(filter);
        }

        public async Task<int> UpdateAsync(AppUser entity)
        {
            if (Validate(entity))
            {
                return await _appUserDAL.UpdateAsync(entity);
            }
            return 0;
        }

        public bool Validate(AppUser entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.UserName))
            {
              
            }

            return isValid;
        }
    }
}
