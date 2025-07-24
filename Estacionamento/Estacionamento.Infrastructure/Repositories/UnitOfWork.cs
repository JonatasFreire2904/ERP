using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;

namespace Estacionamento.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly EstacionamentoDbContext _context;

    public UnitOfWork(EstacionamentoDbContext context)
    {
        _context = context;
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}
