namespace Estacionamento.BlazorUI.Models
{
    public class VagaEntradaDto
    {
        public int Numero { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
    }
}
