using Microsoft.AspNetCore.Mvc;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace DigitalBank.API.Controllers
{
    [ApiController]
    [Route("api/cep")]
    public class EnderecosControllers : ControllerBase
    {
        private readonly IEnderecoService _enderecosService;

        #region CONSTRUTOR
        public EnderecosControllers(IEnderecoService enderecosService)
        {
            _enderecosService = enderecosService;
        }
        #endregion

        #region APIs
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string cep = "15370496";
            var endereco = await _enderecosService.BuscarEnderecoPorCep(cep);
            if (endereco == null)
                return NotFound();

            return Ok(endereco);
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> Get(string cep)
        {
            cep.Replace("-", "");
            var endereco = await _enderecosService.BuscarEnderecoPorCep(cep);
            if (endereco == null)
                return NotFound();

            return Ok(endereco);
        }

        #endregion

    }
}
