
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SearchNarutoAPI;
using SearchNarutoAPI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configura o endereço da API do Naruto
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://dattebayo-api.onrender.com/")
});

// Registra o serviço responsável pelas requisições
builder.Services.AddScoped<NarutoService>();

await builder.Build().RunAsync();
