using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Concrate
{
    public static class seedDatabase
    {
        public static void Seed()
        {
            var context = new NContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {

            }

        }

    }


}
