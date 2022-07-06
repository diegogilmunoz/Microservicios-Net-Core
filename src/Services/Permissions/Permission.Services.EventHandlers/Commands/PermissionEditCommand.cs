using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Services.EventHandlers.Commands
{

        public class PermissionEditCommand : INotification
        {
        public int Id{ get; set; }
        public string NombreEmpleado { get; set; }
            public string ApellidoEmpleado { get; set; }
            public int TipoPermiso { get; set; }
            public DateTime FechaPermiso { get; set; }
            public int Estado { get; set; }

        
    }
}
