namespace Estacionamento.BlazorUI.Models
{
    public class Vaga
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public bool Ocupada { get; set; }
    }
}
