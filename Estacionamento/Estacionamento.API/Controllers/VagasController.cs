using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.API.Controllers
{
    [ApiController]
    [Route("api/vaga")]
    public class VagasController : ControllerBase
    {
        private readonly IVagaService _vagaService;
        private readonly INotaFiscalService _notaFiscalService;

        public VagasController(IVagaService vagaService, INotaFiscalService notaFiscalService)
        {
            _vagaService = vagaService;
            _notaFiscalService = notaFiscalService;
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
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("saida")]
        public async Task<IActionResult> RegistrarSaida([FromBody] VagaSaidaDto dto)
        {
            try
            {
                var resultado = await _vagaService.RegistrarSaidaAsync(dto.Placa);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("saida/notafiscal")]
        public async Task<IActionResult> RegistrarSaidaComNotaFiscal([FromBody] VagaSaidaDto dto)
        {
            try
            {
                var resultado = await _vagaService.RegistrarSaidaAsync(dto.Placa);
                var notaFiscalXml = await _notaFiscalService.GerarNotaFiscalXmlAsync(resultado);
                
                return Content(notaFiscalXml, "application/xml", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("saida/notafiscal/download")]
        public async Task<IActionResult> DownloadNotaFiscal([FromBody] VagaSaidaDto dto)
        {
            try
            {
                var resultado = await _vagaService.RegistrarSaidaAsync(dto.Placa);
                var notaFiscalXml = await _notaFiscalService.GerarNotaFiscalXmlAsync(resultado);
                
                var fileName = $"NotaFiscal_{resultado.Placa}_{DateTime.Now:yyyyMMddHHmmss}.xml";
                var bytes = Encoding.UTF8.GetBytes(notaFiscalXml);
                
                return File(bytes, "application/xml", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
