using Microsoft.AspNetCore.Mvc;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;

namespace DigitalBank.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public IActionResult Get()
        {
            var contas = _contasService.BuscarConta();
            if (contas == null)
                return NotFound();

            return Ok(contas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var conta = _contasService.BuscarContaPorId(id);
            if (conta == null)
                return NotFound();

            return Ok(conta);
        }

        [HttpGet("buscar/numero/{numero}")]
        public IActionResult GetPorNumero(long numero)
        {
            var contas = _contasService.BuscarContaPorNumero(numero);
            if (contas == null)
                return NotFound();

            return Ok(contas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Conta novaConta)
        {
            Conta contaAdicionada = _contasService.AdicionarConta(novaConta);

            return Created("", contaAdicionada);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Conta contaAtualizada)
        {
            contaAtualizada = _contasService.AtualizarConta(id, contaAtualizada);
            if (contaAtualizada == null)
                return NotFound();

            return Ok(contaAtualizada);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            bool remocaoOk = _contasService.RemoverConta(id);
            if (remocaoOk == false)
                return NotFound();

            return NoContent();
        }
        #endregion

    }
}