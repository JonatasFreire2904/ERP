using Estacionamento.Application.Models;
using Estacionamento.Domain.Entities;

namespace Estacionamento.Application.Interfaces
{
    public interface IVagaService
    {
        Task<IEnumerable<Vaga>> ListarVagasAsync();
        Task<Vaga> RegistrarEntradaAsync(VagaEntradaDto dto);
        Task<string> RegistrarSaidaAsync(string placa);
    }
}
