using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Domain
{
   public class Permissions
    {
        [Key]
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }

        [ForeignKey("PermissionTypes")]
        public int TipoPermiso { get; set; }
        public DateTime FechaPermiso { get; set; }
        public int Estado { get; set; }
        public PermissionTypes PermissionTypes { get; set; }
    }
}
