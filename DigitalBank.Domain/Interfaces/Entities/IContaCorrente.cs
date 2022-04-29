using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Entities
{
    internal interface IContaCorrente
    {
        string VerLimite();

        bool AlterarLimite(decimal novoLimite);
    }
}
