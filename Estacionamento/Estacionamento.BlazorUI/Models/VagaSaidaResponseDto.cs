namespace Estacionamento.BlazorUI.Models
{
    public class VagaSaidaResponseDto
    {
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public int NumeroVaga { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public int TempoMinutos { get; set; }
        public decimal ValorPorHora { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
