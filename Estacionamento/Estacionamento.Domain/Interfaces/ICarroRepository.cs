using Estacionamento.Domain.Entities;

namespace Estacionamento.Domain.Interfaces;

public interface ICarroRepository
{
    Task<Carro?> ObterPorPlacaAsync(string placa);
    Task<Carro?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Carro carro);
}
