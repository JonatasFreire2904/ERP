using Estacionamento.Application.Models;

namespace Estacionamento.Application.Interfaces
{
    public interface ITarifaConfigService
    {
        TarifaConfig GetTarifaConfig();
        Task<bool> UpdateTarifaConfigAsync(TarifaConfig tarifaConfig);
    }
}