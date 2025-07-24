using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Estacionamento.Domain.Entities;
using Estacionamento.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Application.Services
{
    public class VagaService : IVagaService
    {
        private readonly EstacionamentoDbContext _context;

        public VagaService(EstacionamentoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vaga>> ListarVagasAsync()
        {
            return await _context.Vagas.ToListAsync();
        }

        public async Task<Vaga> RegistrarEntradaAsync(VagaEntradaDto dto)
        {
            var vaga = await _context.Vagas.FindAsync(dto.VagaId);
            if (vaga == null || vaga.Ocupada)
                throw new Exception("Vaga inválida ou já ocupada.");

            vaga.Ocupada = true;
            vaga.Placa = dto.Placa;
            vaga.Modelo = dto.Modelo;
            vaga.Cor = dto.Cor;
            vaga.DataEntrada = DateTime.Now;

            await _context.SaveChangesAsync();
            return vaga;
        }

        public async Task<string> RegistrarSaidaAsync(string placa)
        {
            var vaga = await _context.Vagas.FirstOrDefaultAsync(v => v.Placa == placa && v.Ocupada);
            if (vaga == null)
                throw new Exception("Veículo não encontrado.");

            var tempo = DateTime.Now - vaga.DataEntrada.Value;
            var minutos = Math.Ceiling(tempo.TotalMinutes);
            var valor = minutos * 0.5m;

            vaga.Ocupada = false;
            vaga.Placa = null;
            vaga.Modelo = null;
            vaga.Cor = null;
            vaga.DataEntrada = null;

            await _context.SaveChangesAsync();
            return $"Tempo estacionado: {minutos} min. Valor a pagar: R$ {valor:F2}";
        }
    }
}
