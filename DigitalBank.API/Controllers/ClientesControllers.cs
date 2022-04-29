using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;

namespace DigitalBank.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesControllers : ControllerBase
    {
        private readonly IClienteService _clientesService;

        #region CONSTRUTOR
        public ClientesControllers(IClienteService clientesService)
        {
            _clientesService = clientesService;
        }
        #endregion

        #region APIs
        // GET: api/clientes
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clientesService.BuscarCliente();
            if (clientes == null)
                return NotFound();

            return Ok(clientes);
        }

        // GET api/clientes/{id}
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cliente = _clientesService.BuscarClientePorId(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        // GET api/clientes/buscar/{nome}
        [HttpGet("buscar/{nome}")]
        public IActionResult Get(string nome)
        {
            var clientes = _clientesService.BuscarClientePorNome(nome);
            if (clientes == null)
                return NotFound();

            return Ok(clientes);
        }

        // POST api/clientes
        [HttpPost]
        public IActionResult Post([FromBody] Cliente novoCliente)
        {
            Cliente clienteAdicionado = _clientesService.AdicionarCliente(novoCliente);

            return Created("", clienteAdicionado);
        }

        // PUT api/clientes/{id}
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Cliente clienteAtualizado)
        {
            clienteAtualizado = _clientesService.AtualizarCliente(id, clienteAtualizado);
            if (clienteAtualizado == null)
                return NotFound();

            return Ok(clienteAtualizado);
        }

        // DELETE api/clientes/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            bool remocaoOk = _clientesService.RemoverCliente(id);
            if (remocaoOk == false)
                return NotFound();

            return NoContent();

        }
        #endregion

    }
}
