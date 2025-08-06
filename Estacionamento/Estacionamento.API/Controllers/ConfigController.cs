using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Estacionamento.API.Controllers
{
    [ApiController]
    [Route("api/config")]
    public class ConfigController : ControllerBase
    {
        private readonly ITarifaConfigService _tarifaConfigService;

        public ConfigController(ITarifaConfigService tarifaConfigService)
        {
            _tarifaConfigService = tarifaConfigService;
        }

        [HttpGet("tarifa")]
        public IActionResult GetTarifaConfig()
        {
            return Ok(_tarifaConfigService.GetTarifaConfig());
        }

        [HttpPut("tarifa")]
        public async Task<IActionResult> UpdateTarifaConfig([FromBody] TarifaConfig tarifaConfig)
        {
            var result = await _tarifaConfigService.UpdateTarifaConfigAsync(tarifaConfig);
            
            if (result)
            {
                return Ok(new { message = "Configuração atualizada com sucesso", config = tarifaConfig });
            }
            else
            {
                return StatusCode(500, new { message = "Erro ao atualizar a configuração" });
            }
        }
    }
}