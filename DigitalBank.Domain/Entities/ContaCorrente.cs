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
        public decimal limite { get; private set; }

        public ContaCorrente() : base()
        {
            limite = 0;
        }

        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            limite = 0;
        }

        public ContaCorrente(Cliente cliente, long numero) : base(cliente, numero)
        {
            limite = 0;
        }
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
        decimal IContaCorrente.AlterarLimite(decimal novoLimite)
        {
            if (novoLimite < 0)
                return -1;
            limite = (novoLimite > IContaCorrente.limiteMaximo ? IContaCorrente.limiteMaximo : novoLimite);
            return limite;
        }

        string IContaCorrente.VerLimite()
        {
            return limite.ToString("C2");
        }
    }
}
