using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Entities
{
    public interface IConta
    {
        bool Sacar(decimal valor);
        bool Depositar(decimal valor);
        string VerSaldo();
        string Finalizar();
    }
}
