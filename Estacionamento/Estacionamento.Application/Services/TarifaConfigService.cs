using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Estacionamento.Application.Services
{
    public class TarifaConfigService : ITarifaConfigService
    {
        private readonly IOptionsMonitor<TarifaConfig> _tarifaConfigMonitor;
        private readonly string _configFilePath;

        public TarifaConfigService(IOptionsMonitor<TarifaConfig> tarifaConfigMonitor, string configFilePath)
        {
            _tarifaConfigMonitor = tarifaConfigMonitor;
            _configFilePath = configFilePath;
        }

        public TarifaConfig GetTarifaConfig()
        {
            return _tarifaConfigMonitor.CurrentValue;
        }

        public async Task<bool> UpdateTarifaConfigAsync(TarifaConfig tarifaConfig)
        {
            try
            {
                // Lê o arquivo de configuração existente
                var configJson = await File.ReadAllTextAsync(_configFilePath);
                
                // Converte para JsonNode para manipulação
                var jsonObject = JsonNode.Parse(configJson)?.AsObject();
                if (jsonObject == null) return false;
                
                // Atualiza a seção TarifaConfig
                if (jsonObject.ContainsKey("TarifaConfig"))
                {
                    var tarifaNode = jsonObject["TarifaConfig"]?.AsObject();
                    if (tarifaNode != null)
                    {
                        tarifaNode["ValorPorHora"] = tarifaConfig.ValorPorHora;
                    }
                }
                else
                {
                    // Cria a seção se não existir
                    var tarifaNode = new JsonObject
                    {
                        ["ValorPorHora"] = tarifaConfig.ValorPorHora
                    };
                    jsonObject["TarifaConfig"] = tarifaNode;
                }
                
                // Salva o arquivo atualizado
                await File.WriteAllTextAsync(_configFilePath, jsonObject.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar configuração: {ex.Message}");
                return false;
            }
        }
    }
}