using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Services.Queries.DTOs
{
   public class PermissionsDto
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string DescPermiso { get; set; }

        [ForeignKey("PermissionTypes")]
        public int TipoPermiso { get; set; }
        public DateTime FechaPermiso { get; set; }
        public int Estado { get; set; }
        public PermissionTypesDto PermissionTypes { get; set; }
    }
}
