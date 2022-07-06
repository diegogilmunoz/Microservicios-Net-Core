using Permission.Persistence.Database;
using Permission.Domain;
using Permission.Services.EventHandlers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.Threading;

namespace Permission.Services.EventHandlers
{



    public class PermissionCreateEventHandler : INotificationHandler<PermissionCreateCommand>
    {

        private readonly ApplicationDBContext _context;
        public PermissionCreateEventHandler(ApplicationDBContext context)
        {
            _context = context;

        }
        public async Task Handle(PermissionCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Permissions
            {
                NombreEmpleado = command.NombreEmpleado,
                ApellidoEmpleado = command.ApellidoEmpleado,
                TipoPermiso = command.TipoPermiso,
                FechaPermiso = command.FechaPermiso,
                Estado = 1
            });

            await _context.SaveChangesAsync();


        }

       
    }
}
