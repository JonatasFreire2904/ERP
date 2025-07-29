using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Models;
using Estacionamento.Domain.Entities;
using Estacionamento.Domain.Interfaces;

namespace Estacionamento.Application.Services
{
    public class VagaService : IVagaService
    {
        private readonly IVagaRepository _vagaRepository;
        private readonly ICarroRepository _carroRepository;
        private readonly IOcupacaoRepository _ocupacaoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VagaService(
            IVagaRepository vagaRepository,
            ICarroRepository carroRepository,
            IOcupacaoRepository ocupacaoRepository,
            IUnitOfWork unitOfWork)
        {
            _vagaRepository = vagaRepository;
            _carroRepository = carroRepository;
            _ocupacaoRepository = ocupacaoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Vaga>> ListarVagasAsync()
        {
            return await _vagaRepository.ListarTodasAsync();
        }

        public async Task<Vaga> RegistrarEntradaAsync(VagaEntradaDto dto)
        {
           
            var vaga = (await _vagaRepository.ListarTodasAsync()).FirstOrDefault(v => v.Numero == dto.Numero);
            if (vaga == null || vaga.Ocupada)
                throw new Exception("Vaga inválida ou já ocupada.");

            var carro = await _carroRepository.ObterPorPlacaAsync(dto.Placa);
            if (carro == null)
            {
                carro = new Carro
                {
                    Placa = dto.Placa,
                    Modelo = dto.Modelo,
                    Cor = dto.Cor
                };
                await _carroRepository.AdicionarAsync(carro);
            }

            var ocupacao = new Ocupacao
            {
                VagaId = vaga.Id,
                CarroId = carro.Id,
                Entrada = DateTime.Now
            };

            await _ocupacaoRepository.AdicionarAsync(ocupacao);

            vaga.Ocupada = true;
            await _vagaRepository.AtualizarAsync(vaga);

            await _unitOfWork.CommitAsync();

            return vaga;
        }



        public async Task<string> RegistrarSaidaAsync(string placa)
        {
            var carro = await _carroRepository.ObterPorPlacaAsync(placa);
            if (carro == null)
                throw new Exception("Carro não encontrado.");

            var ocupacao = await _ocupacaoRepository.ObterAtivaPorCarroIdAsync(carro.Id);
            if (ocupacao == null)
                throw new Exception("Ocupação ativa não encontrada.");

            ocupacao.Saida = DateTime.Now;

            var valor = ocupacao.CalcularValor(5); // exemplo: R$5 por hora

            await _ocupacaoRepository.AtualizarAsync(ocupacao);

            var vaga = await _vagaRepository.ObterPorIdAsync(ocupacao.VagaId);
            if (vaga != null)
            {
                vaga.Ocupada = false;
                await _vagaRepository.AtualizarAsync(vaga);
            }

            await _unitOfWork.CommitAsync();

            return $"Tempo: {ocupacao.TempoOcupado.TotalMinutes:N0} min. Valor a pagar: R$ {valor:F2}";
        }

        public async Task<IEnumerable<VagaOcupadaDto>> ListarVagasOcupadasAsync()
        {
            var vagas = await _vagaRepository.ListarTodasAsync();
            var ocupadas = new List<VagaOcupadaDto>();
            foreach (var vaga in vagas.Where(v => v.Ocupada))
            {
                var ocupacao = await _ocupacaoRepository.ObterAtivaPorVagaIdAsync(vaga.Id);
                if (ocupacao != null)
                {
                    var carro = await _carroRepository.ObterPorIdAsync(ocupacao.CarroId);
                    if (carro != null)
                    {
                        ocupadas.Add(new VagaOcupadaDto
                        {
                            Numero = vaga.Numero,
                            Placa = carro.Placa,
                            Modelo = carro.Modelo,
                            Cor = carro.Cor,
                            Entrada = ocupacao.Entrada
                        });
                    }
                }
            }
            return ocupadas;
        }
    }


}
