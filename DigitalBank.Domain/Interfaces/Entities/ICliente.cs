using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Entities
{
    public interface ICliente
    {
        bool addConta(Conta conta);
        int RetornarQuantidadeContasAtivas();
        int RetornarQuantidadeContasFinalizadas();
    }
}
