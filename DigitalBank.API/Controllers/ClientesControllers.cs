using Microsoft.AspNetCore.Mvc;
using DigitalBank.Domain.Entities;
using DigitalBank.Service.Interfaces;
using System.Threading.Tasks;

namespace DigitalBank.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesControllers : ControllerBase
    {
        private readonly IClienteService _clientesService;

        #region CONSTRUTOR
        //public ClientesControllers() { }

        public ClientesControllers(IClienteService clientesService)
        {
            _clientesService = clientesService;
        }
        #endregion

        #region APIs
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _clientesService.BuscarClientes();
            if (clientes == null)
                return NotFound();

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var cliente = await _clientesService.BuscarClientePorId(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpGet("buscar/{nome}")]
        public async Task<IActionResult> Get(string nome)
        {
            var cliente = await _clientesService.BuscarClientePorNome(nome);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente novoCliente)
        {
            // return NotFound();
            var clienteAdicionado = await _clientesService.AdicionarCliente(novoCliente);

            return Created("", clienteAdicionado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] Cliente clienteAtualizado)
        {
            clienteAtualizado = await _clientesService.AtualizarCliente(id, clienteAtualizado);
            if (clienteAtualizado == null)
                return NotFound();

            return Ok(clienteAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            bool remocaoOk = await _clientesService.RemoverCliente(id);
            if (remocaoOk == false)
                return NotFound();

            return NoContent();
        }
        #endregion

    }
}
