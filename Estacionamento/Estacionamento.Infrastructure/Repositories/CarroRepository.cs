using Estacionamento.Domain.Entities;
using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Infrastructure.Repositories;

public class CarroRepository : ICarroRepository
{
    private readonly EstacionamentoDbContext _context;

    public CarroRepository(EstacionamentoDbContext context)
    {
        _context = context;
    }

    public async Task<Carro?> ObterPorPlacaAsync(string placa) =>
        await _context.Carros.FirstOrDefaultAsync(c => c.Placa == placa);

    public async Task AdicionarAsync(Carro carro) =>
        await _context.Carros.AddAsync(carro);

    public async Task<Carro?> ObterPorIdAsync(Guid id)
    {
        return await _context.Carros.FindAsync(id);
    }
}
