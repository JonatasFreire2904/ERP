namespace Estacionamento.Domain.Entities
{
    public class Ocupacao
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid VagaId { get; set; }
        public Guid CarroId { get; set; }

        public DateTime Entrada { get; set; } = DateTime.Now;
        public DateTime? Saida { get; set; }

        public Vaga? Vaga { get; set; }
        public Carro? Carro { get; set; }

        public bool Ativa => Saida == null;

        public TimeSpan TempoOcupado => (Saida ?? DateTime.Now) - Entrada;

        public decimal CalcularValor(decimal precoHora)
        {
            var horas = Math.Ceiling(TempoOcupado.TotalHours);
            return (decimal)horas * precoHora;
        }
    }
}
