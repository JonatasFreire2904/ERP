using Microsoft.EntityFrameworkCore;
using Estacionamento.Domain.Entities;


namespace Estacionamento.Infrastructure.Data
{
    public class EstacionamentoDbContext : DbContext
    {
        public EstacionamentoDbContext(DbContextOptions<EstacionamentoDbContext> options)
            : base(options) { }

        public DbSet<Vaga> Vagas => Set<Vaga>();
        public DbSet<Carro> Carros => Set<Carro>();
        public DbSet<Ocupacao> Ocupacoes => Set<Ocupacao>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaga>()
                .HasOne(v => v.OcupacaoAtual)
                .WithOne(o => o.Vaga!)
                .HasForeignKey<Ocupacao>(o => o.VagaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ocupacao>()
                .HasOne(o => o.Carro)
                .WithMany()
                .HasForeignKey(o => o.CarroId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed de 100 vagas
            var vagas = new List<Vaga>();
            for (int i = 1; i <= 100; i++)
            {
                vagas.Add(new Vaga
                {
                    Id = Guid.Parse($"00000000-0000-0000-0000-{i:D12}"), // Ids fixos e únicos
                    Codigo = $"V{i:D3}",
                    Numero = i, // Adicionado para o número simples
                    Ocupada = false
                });
            }


            modelBuilder.Entity<Vaga>().HasData(vagas);
        }
    }
}
