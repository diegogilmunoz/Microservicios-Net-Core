using Permission.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Permission.Test.Config
{
   public static class ApplicationDBContextInMemory
    {
         
        public static ApplicationDBContext Get() 
        {

            var options = new DbContextOptionsBuilder<ApplicationDBContext>()
                    .UseInMemoryDatabase(databaseName: $"Catalog.Db")
                    .Options;
            return new ApplicationDBContext(options);
        }

     
    }
}
