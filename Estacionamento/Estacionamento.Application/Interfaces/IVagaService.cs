using Estacionamento.Application.Models;
using Estacionamento.Domain.Entities;

namespace Estacionamento.Application.Interfaces
{
    public interface IVagaService
    {
        Task<IEnumerable<Vaga>> ListarVagasAsync();
        Task<Vaga> RegistrarEntradaAsync(VagaEntradaDto dto);
        Task<VagaSaidaResponseDto> RegistrarSaidaAsync(string placa);
        Task<IEnumerable<VagaOcupadaDto>> ListarVagasOcupadasAsync(); // Novo método
    }
}
