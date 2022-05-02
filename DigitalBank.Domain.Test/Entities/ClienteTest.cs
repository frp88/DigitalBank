using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace DigitalBank.Domain.Test
{
    public class ClienteTest
    {

        private readonly Cliente _cliente;

        public ClienteTest()
        {
            _cliente = new Cliente("Maria", "12345678900");

            var contas = new List<Conta>
            {
                new ContaCorrente(_cliente, 1),
                new ContaCorrente(_cliente, 2),
                new ContaCorrente(_cliente, 3),

            };
            contas[0].Finalizar();
            //contas[1].Finalizar();
            (_cliente.contas as List<Conta>).AddRange(contas);
        }

        [Fact]
        public void RetornarQuantidadeContasAtivasRetorna2()
        {
            var quantidadeContasAtivas = _cliente.RetornarQuantidadeContasAtivas();

            Assert.Equal(2, quantidadeContasAtivas);
        }
        [Fact]
        public void RetornarQuantidadeContasFinalizadasRetorna1()
        {
            var quantidadeContasFinalizadas = _cliente.RetornarQuantidadeContasFinalizadas();

            Assert.Equal(1, quantidadeContasFinalizadas);
        }
    }
}
