using DigitalBank.Domain.Entities;
using System;
using Xunit;

namespace DigitalBank.Domain.Test
{
    public class ContaTest
    {

        private readonly Conta _conta;

        public ContaTest()
        {
            var cliente = new Cliente("Maria", "12345678900");
            _conta = new ContaCorrente(cliente);
        }
       
        [Fact]
        public void SacarValorMaiorDoQueSaldoAtualRetornaErro()
        {
            var resultado = _conta.Sacar(500);
            Assert.False(resultado);
        }

        [Fact]
        public void SacarValorMenorDoQueSaldoAtualOk()
        {
            _conta.Depositar(300);
            var resultado = _conta.Sacar(100);
            Assert.True(resultado);
        }      
        
        [Fact]
        public void FinalizarContaJaFinalizadaRetornaErro()
        {
            _conta.Finalizar();
            var resultado = _conta.Finalizar();
            Assert.NotEqual("ok", resultado);
        }
        [Fact]
        public void FinalizarContaComSaldoDiferenteDeZero()
        {
            _conta.Depositar(50);
            var resultado = _conta.Finalizar();
            Assert.NotEqual("ok", resultado);
        }
        [Fact]
        public void FinalizarContaOk()
        {
            _conta.Finalizar();
            Assert.True(_conta.dataDeFinalizacao.HasValue);
        }
    }
}

