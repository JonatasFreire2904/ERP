using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Domain.Entities
{
    public class Carro
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
    }
}
