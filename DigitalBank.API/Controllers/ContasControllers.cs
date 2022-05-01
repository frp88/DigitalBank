using Microsoft.AspNetCore.Mvc;
using DigitalBank.Domain.Entities;
using DigitalBank.Service.Interfaces;
using System.Threading.Tasks;

namespace DigitalBank.API.Controllers
{
    [ApiController]
    [Route("api/conta")]
    public class ContasControllers : ControllerBase
    {
        private readonly IContaService _contasService;

        #region CONSTRUTOR

        public ContasControllers(IContaService contasService)
        {
            _contasService = contasService;
        }
        #endregion

        #region APIs

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contas = await _contasService.BuscarContas();
            if (contas == null)
                return NotFound();

            return Ok(contas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var conta = await _contasService.BuscarContaPorId(id);
            if (conta == null)
                return NotFound();

            return Ok(conta);
        }

        [HttpGet("buscar/numero/{numero}")]
        public async Task<IActionResult> GetPorNumero(long numero)
        {
            var conta = await _contasService.BuscarContaPorNumero(numero);
            if (conta == null)
                return NotFound();

            return Ok(conta);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Conta novaConta)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Conta contaAdicionada = await _contasService.AdicionarConta(novaConta);
            return Created("", contaAdicionada);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] Conta contaAtualizada)
        {
            contaAtualizada = await _contasService.AtualizarConta(id, contaAtualizada);
            if (contaAtualizada == null)
                return NotFound();
            return Ok(contaAtualizada);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            bool remocaoOk = await _contasService.RemoverConta(id);
            if (remocaoOk == false)
                return NotFound();
            return NoContent();
        }
        #endregion

    }
}