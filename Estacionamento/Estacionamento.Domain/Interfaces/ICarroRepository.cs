using Estacionamento.Domain.Entities;

namespace Estacionamento.Domain.Interfaces;

public interface ICarroRepository
{
    Task<Carro?> ObterPorPlacaAsync(string placa);
    Task AdicionarAsync(Carro carro);
}
