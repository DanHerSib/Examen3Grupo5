using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService ClienteService;
        public ClienteController(IClienteService clienteService)
        {
            this.ClienteService = clienteService;
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteEntity>> Get()
        {
            try
            {
                return await ClienteService.Get();
            }
            catch (Exception ex)
            {
                return new List<ClienteEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<ClienteEntity> Get(int id)
        {
            try
            {
                return await ClienteService.GetById(new ClienteEntity { ClienteId = id });
            }
            catch (Exception ex)
            {

                return new ClienteEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPost]
        public async Task<DBEntity> Create(ClienteEntity entity)
        {
            try
            {
                return await ClienteService.Create(entity);
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(ClienteEntity entity)
        {
            try
            {
                return await ClienteService.Update(entity);
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await ClienteService.Delete(new ClienteEntity() { ClienteId = id });
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
