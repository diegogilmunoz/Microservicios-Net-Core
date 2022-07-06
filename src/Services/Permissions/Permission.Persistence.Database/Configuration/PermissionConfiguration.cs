using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permission.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Persistence.Database.Configuration
{
   public class PermissionConfiguration
    {
        public PermissionConfiguration(EntityTypeBuilder<Permissions> entityBuilder) {

            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.NombreEmpleado).IsRequired();
            entityBuilder.Property(x => x.ApellidoEmpleado).IsRequired();
            entityBuilder.Property(x => x.TipoPermiso).IsRequired();
            entityBuilder.Property(x => x.FechaPermiso).IsRequired();

       
        }

    }
}
