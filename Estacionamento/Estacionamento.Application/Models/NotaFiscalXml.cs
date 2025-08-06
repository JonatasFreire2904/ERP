using System;
using System.Xml.Serialization;

namespace Estacionamento.Application.Models
{
    [XmlRoot("NotaFiscal")]
    public class NotaFiscalXml
    {
        [XmlElement("NumeroNota")]
        public string NumeroNota { get; set; } = string.Empty;

        [XmlElement("DataEmissao")]
        public string DataEmissao { get; set; } = string.Empty;

        [XmlElement("Cliente")]
        public ClienteXml Cliente { get; set; } = new ClienteXml();

        [XmlElement("Servico")]
        public ServicoXml Servico { get; set; } = new ServicoXml();

        [XmlElement("ValorTotal")]
        public string ValorTotal { get; set; } = string.Empty;
    }

    public class ClienteXml
    {
        [XmlElement("Veiculo")]
        public VeiculoXml Veiculo { get; set; } = new VeiculoXml();
    }

    public class VeiculoXml
    {
        [XmlElement("Placa")]
        public string Placa { get; set; } = string.Empty;

        [XmlElement("Modelo")]
        public string Modelo { get; set; } = string.Empty;

        [XmlElement("Cor")]
        public string Cor { get; set; } = string.Empty;
    }

    public class ServicoXml
    {
        [XmlElement("Descricao")]
        public string Descricao { get; set; } = string.Empty;

        [XmlElement("NumeroVaga")]
        public string NumeroVaga { get; set; } = string.Empty;

        [XmlElement("DataHoraEntrada")]
        public string DataHoraEntrada { get; set; } = string.Empty;

        [XmlElement("DataHoraSaida")]
        public string DataHoraSaida { get; set; } = string.Empty;

        [XmlElement("TempoEstacionado")]
        public string TempoEstacionado { get; set; } = string.Empty;

        [XmlElement("ValorHora")]
        public string ValorHora { get; set; } = string.Empty;

        [XmlElement("ValorTotal")]
        public string ValorTotal { get; set; } = string.Empty;
    }
}