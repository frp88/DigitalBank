using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Entities
{
    internal interface IConta
    {
        decimal Sacar(decimal valor);
        decimal Depositar(decimal valor);
        string VerSaldo();
        string Finalizar();
    }
}
