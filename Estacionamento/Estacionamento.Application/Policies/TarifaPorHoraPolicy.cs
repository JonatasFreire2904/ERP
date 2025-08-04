using Estacionamento.Domain.Interfaces;
using System;

namespace Estacionamento.Application.Policies
{
    public class TarifaPorHoraPolicy : ITarifaPolicy
    {
        public decimal CalcularValor(TimeSpan tempo, decimal precoBasePorHora)
        {
            var horas = Math.Ceiling(tempo.TotalHours);
            return (decimal)horas * precoBasePorHora;
        }
    }
}
