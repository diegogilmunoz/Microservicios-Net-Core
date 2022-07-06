using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permission.Persistence.Database;
using Permission.Test.Config;
using System;

namespace Permission.Test
{
    [TestClass]
    public class PermissionCreateEventHandlerTest
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
                Estado= 1

            });

            context.SaveChanges();
        }


       
    }
}
