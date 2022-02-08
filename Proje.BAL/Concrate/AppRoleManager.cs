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
    public class AppRoleManager : IAppRoleService
    {
        public IAppRoleDAL _appRoleDAL;

        public AppRoleManager(IAppRoleDAL customMenuDal)
        {
            _appRoleDAL = customMenuDal;
        }
        public string ErrorMessage { get; set; }

        public async Task<int> CountAllasync(Expression<Func<AppRole, bool>> filter = null)
        {
            return await _appRoleDAL.CountAllasync(filter);
        }

        public async Task<int> CreateAsync(AppRole entity)
        {
            if (Validate(entity))
            {
                return await _appRoleDAL.CreateAsync(entity);
            }
            return 500;
        }

        public async Task<int> DeleteAsync(AppRole entity)
        {
            return await _appRoleDAL.DeleteAsync(entity);
        }

        public async Task<List<AppRole>> GetAllAsync(Expression<Func<AppRole, bool>> filter = null)
        {
            return await _appRoleDAL.GetAllAsync(filter);
        }

        public async Task<AppRole> GetByIdAsync(int id)
        {
            return await _appRoleDAL.GetByIdAsync(id);
        }

        public async Task<AppRole> GetOneAsync(Expression<Func<AppRole, bool>> filter)
        {
            return await _appRoleDAL.GetOneAsync(filter);
        }

        public async Task<int> UpdateAsync(AppRole entity)
        {
            if (Validate(entity))
            {
                return await _appRoleDAL.UpdateAsync(entity);
            }
            return 0;
        }

        public bool Validate(AppRole entity)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Name alanını giriniz.";
                isValid = false;
            }

            return isValid;
        }
    }
}
