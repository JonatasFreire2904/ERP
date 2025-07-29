using Estacionamento.Domain.Entities;
using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Infrastructure.Repositories;

public class OcupacaoRepository : IOcupacaoRepository
{
    private readonly EstacionamentoDbContext _context;

    public OcupacaoRepository(EstacionamentoDbContext context)
    {
        _context = context;
    }

    public async Task<Ocupacao?> ObterAtivaPorVagaAsync(Guid vagaId) =>
        await _context.Ocupacoes.FirstOrDefaultAsync(o => o.VagaId == vagaId && o.Saida == null);

    public async Task<Ocupacao?> ObterPorIdAsync(Guid id) =>
        await _context.Ocupacoes.Include(o => o.Carro).Include(o => o.Vaga).FirstOrDefaultAsync(o => o.Id == id);

    public async Task AdicionarAsync(Ocupacao ocupacao) =>
        await _context.Ocupacoes.AddAsync(ocupacao);

    public async Task AtualizarAsync(Ocupacao ocupacao)
    {
        _context.Ocupacoes.Update(ocupacao);
        await Task.CompletedTask;
    }

    public async Task<Ocupacao?> ObterAtivaPorCarroIdAsync(Guid carroId)
    {
        return await _context.Ocupacoes
            .FirstOrDefaultAsync(o => o.CarroId == carroId && o.Saida == null);
    }
}
