using System.Net.Http.Json;
using Estacionamento.BlazorUI.Models;

namespace Estacionamento.BlazorUI.Services
{
    public class ApiClient
    {
        private readonly HttpClient _http;

        public ApiClient(HttpClient http) => _http = http;

        public async Task<List<Vaga>> GetVagas() =>
            await _http.GetFromJsonAsync<List<Vaga>>("api/vaga") ?? new();

        public async Task<List<VagaOcupadaDto>> GetVagasOcupadas() =>
            await _http.GetFromJsonAsync<List<VagaOcupadaDto>>("api/vaga/ocupadas") ?? new();

        public async Task RegistrarEntrada(VagaEntradaDto dto)
        {
            var resp = await _http.PostAsJsonAsync("api/vaga/entrada", dto);
            resp.EnsureSuccessStatusCode();
        }

        public async Task<VagaSaidaResponseDto> RegistrarSaida(string placa)
        {
            var resp = await _http.PostAsJsonAsync("api/vaga/saida", new VagaSaidaDto { Placa = placa });
            resp.EnsureSuccessStatusCode();
            return (await resp.Content.ReadFromJsonAsync<VagaSaidaResponseDto>())!;
        }

        public async Task<string> RegistrarSaidaComNotaFiscalXml(string placa)
        {
            var resp = await _http.PostAsJsonAsync("api/vaga/saida/notafiscal", new VagaSaidaDto { Placa = placa });
            resp.EnsureSuccessStatusCode();
            return await resp.Content.ReadAsStringAsync(); // XML
        }
    }
}
