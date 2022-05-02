using Microsoft.AspNetCore.Mvc;
using DigitalBank.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace DigitalBank.Application.Controllers
{
    [ApiController]
    [Route("api/cep")]
    public class EnderecosControllers : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        #region CONSTRUTOR
        public EnderecosControllers(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
        #endregion

        #region APIs
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string cep = "15370496";
            var endereco = await _enderecoService.BuscarEnderecoPorCep(cep);
            if (endereco == null)
                return NotFound();

            return Ok(endereco);
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> Get(string cep)
        {
            cep.Replace("-", "");
            var endereco = await _enderecoService.BuscarEnderecoPorCep(cep);
            if (endereco == null)
                return NotFound();

            return Ok(endereco);
        }

        #endregion

    }
}
