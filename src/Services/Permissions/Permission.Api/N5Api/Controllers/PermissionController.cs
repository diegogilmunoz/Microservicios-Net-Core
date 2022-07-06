using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Permission.Services.EventHandlers.Commands;
using Permission.Services.Queries;
using Permission.Services.Queries.DTOs;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5Api.Controllers
{

    
    [ApiController]
    [Route("permission")]

    public class PermissionController : ControllerBase
    {
        private readonly IPermissionQueryServices _permissionQueryServices;
        private readonly ILogger<DefaultController> _logger;
        private readonly IMediator _mediator;

        public PermissionController(ILogger<DefaultController> logger, IPermissionQueryServices permissionQueryServices , IMediator mediator)
        {
            _logger = logger;
            _permissionQueryServices = permissionQueryServices;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<PermissionsDto>> GetAll(int page=1,int take =10, string ids = null)
        {
            IEnumerable<int> permission = null;
            if (!string.IsNullOrEmpty(ids))
            {
                permission = ids.Split(',').Select(x => Convert.ToInt32(x));
            }
            return await _permissionQueryServices.GetAllAsync(page, take, permission);
        }

        [HttpGet("{id}")]
        public async Task<PermissionsDto> Get(int id) 
        {
            return await _permissionQueryServices.GetAsync(id);
        }


        [HttpPost]
        public async Task<IActionResult> Create(PermissionCreateCommand  command)
        {
            await _mediator.Publish(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(PermissionEditCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}
