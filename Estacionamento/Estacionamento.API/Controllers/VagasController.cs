using Estacionamento.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.API.Controllers
{
    [ApiController]
    [Route("api/vaga")]
    public class VagasController : ControllerBase
    {
        private readonly IVagaService _vagaService;
    }
}
