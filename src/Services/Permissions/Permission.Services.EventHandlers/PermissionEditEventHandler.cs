using MediatR;
using Microsoft.EntityFrameworkCore;
using Permission.Domain;
using Permission.Persistence.Database;
using Permission.Services.EventHandlers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Permission.Services.EventHandlers
{
  public  class PermissionEditEventHandler : INotificationHandler<PermissionEditCommand>
    {
        private readonly ApplicationDBContext _context;
        public PermissionEditEventHandler(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task Handle(PermissionEditCommand command, CancellationToken cancellationToken)
        {


            //using (var dbContext = new DbContextBuilder().BuildDbContext())
            //{
            //    dbContext.Update(entity);
            //    await dbContext.SaveChangesAsync();
            //}

            var collection=  _context.Permissions.SingleOrDefault(x => x.Id == command.Id);
            if (collection != null)
            {
                collection.NombreEmpleado = command.NombreEmpleado is null ? collection.NombreEmpleado : command.NombreEmpleado;
                collection.ApellidoEmpleado = command.ApellidoEmpleado is null ? collection.ApellidoEmpleado : command.ApellidoEmpleado;
                collection.TipoPermiso = command.TipoPermiso;
                collection.FechaPermiso = command.FechaPermiso;

                _context.Update(collection);
                await _context.SaveChangesAsync();
                //db.SaveChanges();
            }
           

           

         


        }
    }
}
