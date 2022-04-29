using DigitalBank.Domain.Entities;
using System;
using Xunit;

namespace DigitalBank.Domain.Test
{
    public class ContaCorrenteTest
    {
        [Fact]
        public void FinalizarContaSemErros()
        {
            var cliente = new Cliente("Maria", "12345678900");
            var conta = new ContaCorrente(cliente);
            conta.Finalizar();
            Assert.True(conta.dataDeFinalizacao.HasValue);
        }
        [Fact]
        public void FinalizarContaJaFinalizadaRetornaErro()
        {
            var cliente = new Cliente("Maria", "12345678900");
            var conta = new ContaCorrente(cliente);
            conta.Finalizar();
            var resultado = conta.Finalizar();
            Assert.NotEqual("ok", resultado);
        }
        [Fact]
        public void FinalizarContaComSaldoDiferenteDeZero()
        {
            var cliente = new Cliente("Maria", "12345678900");
            var conta = new ContaCorrente(cliente);
            conta.Depositar(100);
            var resultado = conta.Finalizar();
            Assert.NotEqual("ok", resultado);
        }
    }
}

