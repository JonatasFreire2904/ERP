using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Estacionamento.Application.Services
{
    public class NotaFiscalService : INotaFiscalService
    {
        public NotaFiscalXml CriarNotaFiscalModel(VagaSaidaResponseDto saidaResponse)
        {
            // Gera um número de nota fiscal baseado na data e hora atual
            string numeroNota = $"NF-{DateTime.Now:yyyyMMddHHmmss}";
            
            var notaFiscal = new NotaFiscalXml
            {
                NumeroNota = numeroNota,
                DataEmissao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Cliente = new ClienteXml
                {
                    Veiculo = new VeiculoXml
                    {
                        Placa = saidaResponse.Placa,
                        Modelo = saidaResponse.Modelo,
                        Cor = saidaResponse.Cor
                    }
                },
                Servico = new ServicoXml
                {
                    Descricao = "Serviço de Estacionamento",
                    NumeroVaga = saidaResponse.NumeroVaga.ToString(),
                    DataHoraEntrada = saidaResponse.Entrada.ToString("yyyy-MM-dd HH:mm:ss"),
                    DataHoraSaida = saidaResponse.Saida.ToString("yyyy-MM-dd HH:mm:ss"),
                    TempoEstacionado = $"{saidaResponse.TempoMinutos} minutos",
                    ValorHora = $"R$ {saidaResponse.ValorPorHora:F2}",
                    ValorTotal = $"R$ {saidaResponse.ValorTotal:F2}"
                },
                ValorTotal = $"R$ {saidaResponse.ValorTotal:F2}"
            };

            return notaFiscal;
        }

        public async Task<string> GerarNotaFiscalXmlAsync(VagaSaidaResponseDto saidaResponse)
        {
            var notaFiscal = CriarNotaFiscalModel(saidaResponse);

            // Serializa o objeto para XML
            var serializer = new XmlSerializer(typeof(NotaFiscalXml));
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true,
                OmitXmlDeclaration = false
            };

            using (var memoryStream = new MemoryStream())
            {
                using (var xmlWriter = XmlWriter.Create(memoryStream, settings))
                {
                    // Adiciona o namespace XML
                    var ns = new XmlSerializerNamespaces();
                    ns.Add("", ""); // Remove o namespace padrão

                    serializer.Serialize(xmlWriter, notaFiscal, ns);
                }

                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}