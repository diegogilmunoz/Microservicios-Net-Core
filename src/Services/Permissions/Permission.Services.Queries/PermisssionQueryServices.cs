using Microsoft.EntityFrameworkCore;
using Permission.Persistence.Database;
using Permission.Services.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Services.Queries
{

    public interface IPermissionQueryServices
    {
        Task<DataCollection<PermissionsDto>> GetAllAsync(int page, int take, IEnumerable<int> permission);
        Task<PermissionsDto> GetAsync(int id);
    }

    public class PermisssionQueryServices : IPermissionQueryServices
    {
             
        private readonly ApplicationDBContext _context ;
        public PermisssionQueryServices(ApplicationDBContext context) {
            _context = context;
        }

        public async Task<DataCollection<PermissionsDto>> GetAllAsync(int page, int take, IEnumerable<int> permission ) 
        {


            try
            {

                                          
                                          
                                          

                var collection = await _context.Permissions.Include(x=>x.PermissionTypes)
                              .Where(x => permission == null || permission.Contains(x.Id))
                              .OrderBy(x => x.Id).GetPagedAsync(page, take);
                return collection.MapTo<DataCollection<PermissionsDto>>();

           

            }
            catch (Exception ex)
            {
                string pe = ex.Message;
               
            }
            return null;
          

        }
        public async Task<PermissionsDto> GetAsync(int id) 
        {

            return (await _context.Permissions.SingleAsync(x => x.Id == id)).MapTo<PermissionsDto>();
        }
    }
}
