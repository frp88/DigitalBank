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
        // GET: api/contas
        [HttpGet]
        public IActionResult Get()
        {
            var contas = _contasService.BuscarConta();
            if (contas == null)
                return NotFound();

            return Ok(contas);
        }

        // GET api/contas/{id}
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var conta = _contasService.BuscarContaPorId(id);
            if (conta == null)
                return NotFound();

            return Ok(conta);
        }

        // GET api/contas/buscar/{nome}
        [HttpGet("buscar/numero/{numero}")]
        public IActionResult GetPorNumero(long numero)
        {
            var contas = _contasService.BuscarContaPorNumero(numero);
            if (contas == null)
                return NotFound();

            return Ok(contas);
        }

        // POST api/contas
        [HttpPost]
        public IActionResult Post([FromBody] Conta novaConta)
        {
            Conta contaAdicionada = _contasService.AdicionarConta(novaConta);

            return Created("", contaAdicionada);
        }

        // PUT api/contas/{id}
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Conta contaAtualizada)
        {
            contaAtualizada = _contasService.AtualizarConta(id, contaAtualizada);
            if (contaAtualizada == null)
                return NotFound();

            return Ok(contaAtualizada);
        }

        // DELETE api/contas/{id}
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