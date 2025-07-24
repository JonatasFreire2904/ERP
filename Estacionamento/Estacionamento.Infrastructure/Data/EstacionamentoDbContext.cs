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
        }
    }
}
