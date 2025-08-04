using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Domain.Interfaces
{
    public interface ITarifaPolicy
    {
        decimal CalcularValor(TimeSpan tempo, decimal precoBasePorHora);
    }
}
