using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Entities
{
    public interface IContaCorrente
    {
        const int limiteMaximo = 1000;
        string VerLimite();

        bool AlterarLimite(decimal novoLimite);
    }
}
