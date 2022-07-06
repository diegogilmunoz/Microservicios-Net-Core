using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Test.Config
{
    public class PermissionGetAllTest
    {
        [TestMethod]
        public void TryGetAll()
        {
          

            var context = ApplicationDBContextInMemory.Get();
            var collection = context.Permissions.Include(x => x.PermissionTypes)
                          .OrderBy(x => x.Id).ToList();
      

           
         
        }



    }
}
