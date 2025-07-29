using System.Text.Json.Serialization;

namespace Estacionamento.Domain.Entities
{
    public class Vaga
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Numero { get; set; } // Simple spot number
        public string Codigo { get; set; } = string.Empty;
        public bool Ocupada { get; set; } = false;

        //Relacionamento com Ocupacao
        [JsonIgnore]
        public Ocupacao? OcupacaoAtual { get; set; }
    }
}
