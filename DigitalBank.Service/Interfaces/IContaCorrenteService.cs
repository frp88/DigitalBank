using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Service.Interfaces
{
    public interface IContaCorrenteService
    {
        string VerLimite();

        decimal AlterarLimite(decimal novoLimite);

    }
}
