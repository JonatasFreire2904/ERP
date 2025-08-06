using Estacionamento.Application.Models;
using System.Threading.Tasks;

namespace Estacionamento.Application.Interfaces
{
    public interface INotaFiscalService
    {
        Task<string> GerarNotaFiscalXmlAsync(VagaSaidaResponseDto saidaResponse);
        NotaFiscalXml CriarNotaFiscalModel(VagaSaidaResponseDto saidaResponse);
    }
}