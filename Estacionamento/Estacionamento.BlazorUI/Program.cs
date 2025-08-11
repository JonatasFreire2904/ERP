using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Estacionamento.BlazorUI;
using Estacionamento.BlazorUI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Base da API — ajuste se sua API usar outra porta
var apiBase = "https://localhost:7186";
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(apiBase) });

// Nosso client da API
builder.Services.AddScoped<ApiClient>();

await builder.Build().RunAsync();
