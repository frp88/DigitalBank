using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Services
{
    public class ContaCorrenteService : ContaService, IContaCorrenteService
    {
        public ContaCorrenteService()
        {

        }

        decimal IContaCorrenteService.AlterarLimite(decimal novoLimite)
        {
            throw new NotImplementedException();
        }

        string IContaCorrenteService.VerLimite()
        {
            throw new NotImplementedException();
        }
    }
}
