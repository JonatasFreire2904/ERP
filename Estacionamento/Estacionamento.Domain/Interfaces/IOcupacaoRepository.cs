using Estacionamento.Domain.Entities;

namespace Estacionamento.Domain.Interfaces;

public interface IOcupacaoRepository
{
    Task<Ocupacao?> ObterAtivaPorVagaIdAsync(Guid vagaId);
    Task<Ocupacao?> ObterAtivaPorCarroIdAsync(Guid carroId);
    Task<Ocupacao?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Ocupacao ocupacao);
    Task AtualizarAsync(Ocupacao ocupacao);
}
