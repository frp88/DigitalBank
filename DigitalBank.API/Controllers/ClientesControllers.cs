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
            return NotFound();
            //var clientes = _clientesService.BuscarClientePorNome(nome);
            //if (clientes == null)
            //    return NotFound();

            //return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente novoCliente)
        {
            // return NotFound();
            var clienteAdicionado = _clientesService.AdicionarCliente(novoCliente);

            return Created("", clienteAdicionado);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Cliente clienteAtualizado)
        {
            return NotFound();

            //clienteAtualizado = _clientesService.AtualizarCliente(id, clienteAtualizado);
            //if (clienteAtualizado == null)
            //    return NotFound();

            //return Ok(clienteAtualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return NotFound();

            //bool remocaoOk = _clientesService.RemoverCliente(id);
            //if (remocaoOk == false)
            //    return NotFound();

            //return NoContent();
        }
        #endregion

    }
}
