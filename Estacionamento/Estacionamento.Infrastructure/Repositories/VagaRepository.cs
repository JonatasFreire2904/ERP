using Estacionamento.Domain.Entities;
using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Estacionamento.Infrastructure.Repositories;

public class VagaRepository : IVagaRepository
{
    private readonly EstacionamentoDbContext _context;

    public VagaRepository(EstacionamentoDbContext context)
    {
        _context = context;
    }

    public async Task<Vaga?> ObterPorIdAsync(Guid id) =>
        await _context.Vagas.Include(v => v.OcupacaoAtual).FirstOrDefaultAsync(v => v.Id == id);

    public async Task<List<Vaga>> ListarTodasAsync() =>
        await _context.Vagas.Include(v => v.OcupacaoAtual).ToListAsync();

    public async Task<List<Vaga>> ListarDisponiveisAsync() =>
        await _context.Vagas.Where(v => !v.Ocupada).ToListAsync();

    public async Task AdicionarAsync(Vaga vaga) =>
        await _context.Vagas.AddAsync(vaga);

    public async Task AtualizarAsync(Vaga vaga)
    {
        _context.Vagas.Update(vaga);
        await Task.CompletedTask;
    }

    public async Task<Vaga?> ObterPrimeiraDisponivelAsync()
    {
        return await _context.Vagas
            .Include(v => v.OcupacaoAtual)
            .FirstOrDefaultAsync(v => !v.Ocupada);
    }

}
