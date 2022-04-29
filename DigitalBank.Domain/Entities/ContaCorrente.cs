using DigitalBank.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Entities
{
    public class ContaCorrente : Conta, IContaCorrente
    {
        public decimal limite { get; private set; } = 0;

        public ContaCorrente() : base() { }

        public ContaCorrente(Cliente cliente) : base(cliente) { }
        
        public ContaCorrente(Cliente cliente, long numero) : base(cliente, numero) { }
        public ContaCorrente(Cliente cliente, long numero, decimal limite) : base(cliente, numero)
        {
            this.limite = limite;
        }
        public override decimal Sacar(decimal valor)
        {
            if (valor > (base.saldo + limite))
                return -1;
            base.Sacar(valor);
            return saldo;
        }
        public decimal AlterarLimite(decimal novoLimite)
        {
            if (novoLimite < 0)
                return -1;
            limite = (novoLimite > IContaCorrente.limiteMaximo ? IContaCorrente.limiteMaximo : novoLimite);
            return limite;
        }

        public string VerLimite()
        {
            return limite.ToString("C2");
        }
    }
}
