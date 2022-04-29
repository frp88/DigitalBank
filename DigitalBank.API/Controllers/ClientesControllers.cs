using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clientesService.BuscarCliente();
            if (clientes == null)
                return NotFound();

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cliente = _clientesService.BuscarClientePorId(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpGet("buscar/{nome}")]
        public IActionResult Get(string nome)
        {
            var clientes = _clientesService.BuscarClientePorNome(nome);
            if (clientes == null)
                return NotFound();

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente novoCliente)
        {
            Cliente clienteAdicionado = _clientesService.AdicionarCliente(novoCliente);

            return Created("", clienteAdicionado);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Cliente clienteAtualizado)
        {
            clienteAtualizado = _clientesService.AtualizarCliente(id, clienteAtualizado);
            if (clienteAtualizado == null)
                return NotFound();

            return Ok(clienteAtualizado);
        }

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
