using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Converter.Transform;
using Converter.Data;
using MudBlazor.Services;
using Converter;
using Microsoft.AspNetCore.Components.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// DI Registrations
builder.Services.AddScoped<IData, AreaData>();
builder.Services.AddScoped<IData, LengthData>();
builder.Services.AddScoped<ITransformer, Transformer>();
builder.Services.AddSingleton<AppSettings>();

builder.Services.AddMudServices();

var host = builder.Build();
await host.RunAsync();
