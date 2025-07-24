using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Estacionamento.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configurar o DbContext com SQLite
builder.Services.AddDbContext<EstacionamentoDbContext>(options =>
    options.UseSqlite("Data Source=estacionamento.db"));

// 💉 Injeção de Dependência dos Repositórios e UnitOfWork
builder.Services.AddScoped<IVagaRepository, VagaRepository>();
builder.Services.AddScoped<ICarroRepository, CarroRepository>();
builder.Services.AddScoped<IOcupacaoRepository, OcupacaoRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IVagaService, VagaService>();

// 📦 AddControllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen(); // This line is commented out as per the edit hint

// 🌐 CORS (para Blazor WebAssembly)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazor",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// 🛠 Middleware de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger(); // This line is commented out as per the edit hint
    // app.UseSwaggerUI(); // Enable Swagger UI in development
}

// 🌐 Ativar CORS
app.UseCors("AllowBlazor");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
