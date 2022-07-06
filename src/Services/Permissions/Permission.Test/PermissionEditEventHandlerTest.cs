using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permission.Test.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Test
{
  public  class PermissionEditEventHandlerTest
    {
        [TestMethod]
        public void TryCreatePermission()
        {
            var context = ApplicationDBContextInMemory.Get();
            var nomEmpleado = "Diego";
            var apeEmpleado = "Gil";
            var tipoPermiso = 1;
            DateTime fechaPermiso = DateTime.Now;

            context.Permissions.Add(new Domain.Permissions
            {
                NombreEmpleado = nomEmpleado,
                ApellidoEmpleado = apeEmpleado,
                TipoPermiso = tipoPermiso,
                FechaPermiso = fechaPermiso,
                Estado = 1

            });

            var cod = context.SaveChanges();

            var collection = context.Permissions.SingleOrDefault(x => x.Id == cod);
            if (collection != null)
            {
                collection.NombreEmpleado = "Ibrahim";
                collection.ApellidoEmpleado = "Raul";
                collection.TipoPermiso =1;
                collection.FechaPermiso = DateTime.Now;

                context.Update(collection);
                 context.SaveChangesAsync();
                
            }


        }

    }
}
