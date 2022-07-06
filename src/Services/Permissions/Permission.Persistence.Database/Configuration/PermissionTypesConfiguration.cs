using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permission.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Persistence.Database.Configuration
{
   public class PermissionTypesConfiguration
    {
        public PermissionTypesConfiguration(EntityTypeBuilder<PermissionTypes> entityBuilder)
        {

            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.Descripcion).IsRequired();



        }
    }
}
