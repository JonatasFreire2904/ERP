using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.API.Controllers
{
    [ApiController]
    [Route("api/vaga")]
    public class VagasController : ControllerBase
    {
        private readonly IVagaService _vagaService;

        public VagasController(IVagaService vagaService)
        {
            _vagaService = vagaService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarVagas()
        {
            var vagas = await _vagaService.ListarVagasAsync();
            return Ok(vagas);
        }
        [HttpGet("ocupadas")]
        public async Task<IActionResult> ListarVagasOcupadas()
        {
            var vagas = await _vagaService.ListarVagasOcupadasAsync();
            return Ok(vagas);
        }
        [HttpPost("entrada")]
        public async Task<IActionResult> RegistrarEntrada([FromBody] VagaEntradaDto dto)
        {
            try
            {                
                var vaga = await _vagaService.RegistrarEntradaAsync(dto);
                return Ok(vaga);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpPost("saida")]
        public async Task<IActionResult> RegistrarSaida([FromBody] VagaSaidaDto dto)
        {
            var resultado = await _vagaService.RegistrarSaidaAsync(dto.Placa);
            return Ok(resultado);
        }
    }
}
