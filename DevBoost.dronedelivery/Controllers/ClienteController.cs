using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBoost.dronedelivery.Domain;
using DevBoost.DroneDelivery.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevBoost.dronedelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/<ClienteController>
        [HttpGet, Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            return Ok(await _clienteService.GetAll());
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}"), Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _clienteService.GetById(id);
            return cliente;
        }

        // POST api/<ClienteController>
        [HttpPost, Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _clienteService.Insert(cliente);
            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}"), Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult<Cliente>> DeleteCliente(int id)
        {
            var cliente = await _clienteService.GetById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            var result = await _clienteService.Delete(cliente);

            if (!result)
                return BadRequest();

            return Ok(cliente);
        }
    }
}
