using Estacionamento.Domain.Entities;

namespace Estacionamento.Domain.Interfaces;

public interface IVagaRepository
{
    Task<Vaga?> ObterPorIdAsync(Guid id);
    Task<List<Vaga>> ListarTodasAsync();
    Task<List<Vaga>> ListarDisponiveisAsync();
    Task AdicionarAsync(Vaga vaga);
    Task AtualizarAsync(Vaga vaga);
}
