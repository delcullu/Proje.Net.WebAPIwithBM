using Proje.DAL.Abstract;
using Proje.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Concrate
{
    public class EFCoreAppRoleDAL : EFCoreGenericRepository<AppRole, NContext>, IAppRoleDAL
    {
    }
}
