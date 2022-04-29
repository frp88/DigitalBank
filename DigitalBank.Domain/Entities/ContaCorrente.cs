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

        }

        public override decimal Sacar(decimal valor)
        {
            if (valor > (base.saldo + limite))
                return -1;
            base.Sacar(valor);
            return saldo;
        }
        bool IContaCorrente.AlterarLimite(decimal novoLimite)
        {
            throw new NotImplementedException();
        }

        string IContaCorrente.VerLimite()
        {
            throw new NotImplementedException();
        }
    }
}
