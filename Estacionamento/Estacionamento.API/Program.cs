using Estacionamento.Domain.Interfaces;
using Estacionamento.Infrastructure.Data;
using Estacionamento.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Application.Interfaces;
using Estacionamento.Application.Services;
using Estacionamento.Application.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔧 DbContext (SQLite)
builder.Services.AddDbContext<EstacionamentoDbContext>(options =>
    options.UseSqlite("Data Source=estacionamento.db"));

// 💉 DI – Repositórios e UoW
builder.Services.AddScoped<IVagaRepository, VagaRepository>();
builder.Services.AddScoped<ICarroRepository, CarroRepository>();
builder.Services.AddScoped<IOcupacaoRepository, OcupacaoRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// ⚙️ Config de Tarifa
builder.Services.Configure<TarifaConfig>(builder.Configuration.GetSection("TarifaConfig"));

// 👉 Caminho do appsettings (se precisar em serviços)
var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
builder.Services.AddSingleton(configFilePath);

// 🧩 Serviços de aplicação
builder.Services.AddScoped<IVagaService, VagaService>();
builder.Services.AddScoped<ITarifaConfigService, TarifaConfigService>();
builder.Services.AddScoped<INotaFiscalService, NotaFiscalService>();

// 📦 Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🌐 CORS (libera a origem do Blazor)
const string BlazorCors = "AllowBlazor";
builder.Services.AddCors(options =>
{
    options.AddPolicy(BlazorCors, policy =>
        policy.WithOrigins(
                "https://localhost:7109", // Blazor HTTPS
                "http://localhost:5292"   // Blazor HTTP
            )
            .AllowAnyHeader()
            .AllowAnyMethod()
    );
});

var app = builder.Build();

// 🛠 Dev middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🌐 Ativar CORS (antes de mapear controllers)
app.UseCors(BlazorCors);

app.UseAuthorization();

app.MapControllers();

app.Run();
