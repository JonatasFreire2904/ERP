using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Estacionamento.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Services;
using Estacionamento.Application.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configurar o DbContext com SQLite
builder.Services.AddDbContext<EstacionamentoDbContext>(options =>
    options.UseSqlite("Data Source=estacionamento.db"));

// 💉 Injeção de Dependência dos Repositórios e UnitOfWork
builder.Services.AddScoped<IVagaRepository, VagaRepository>();
builder.Services.AddScoped<ICarroRepository, CarroRepository>();
builder.Services.AddScoped<IOcupacaoRepository, OcupacaoRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Configuração da Tarifa
builder.Services.Configure<TarifaConfig>(builder.Configuration.GetSection("TarifaConfig"));

// Registrar o caminho do arquivo de configuração para o serviço de configuração
var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
builder.Services.AddSingleton(configFilePath);

// Registrar serviços
builder.Services.AddScoped<IVagaService, VagaService>();
builder.Services.AddScoped<ITarifaConfigService, TarifaConfigService>();
builder.Services.AddScoped<INotaFiscalService, NotaFiscalService>();

// 📦 AddControllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🌐 Ativar CORS
app.UseCors("AllowBlazor");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
