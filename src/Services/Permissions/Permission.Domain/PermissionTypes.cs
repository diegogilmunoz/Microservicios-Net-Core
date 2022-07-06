using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Domain
{
   public class PermissionTypes
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

    }
}
