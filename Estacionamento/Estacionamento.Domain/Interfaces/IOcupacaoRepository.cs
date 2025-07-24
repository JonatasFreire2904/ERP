using Estacionamento.Domain.Entities;

namespace Estacionamento.Domain.Interfaces;

public interface IOcupacaoRepository
{
    Task<Ocupacao?> ObterAtivaPorVagaAsync(Guid vagaId);
    Task<Ocupacao?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Ocupacao ocupacao);
    Task AtualizarAsync(Ocupacao ocupacao);
}
