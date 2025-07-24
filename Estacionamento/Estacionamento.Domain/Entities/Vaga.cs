
namespace Estacionamento.Domain.Entities
{
    public class Vaga
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Codigo { get; set; } = string.Empty;
        public bool Ocupada { get; set; } = false;

        //Relacionamento com Ocupacao
        public Ocupacao? OcupacaoAtual { get; set; }
    }
}
