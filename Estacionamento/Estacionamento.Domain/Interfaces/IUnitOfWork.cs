namespace Estacionamento.Domain.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}
