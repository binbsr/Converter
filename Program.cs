using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Converter.Transform;
using Converter.Data;
using System.Globalization;
using Microsoft.JSInterop;
using MudBlazor.Services;

namespace Converter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            // DI Registrations
            builder.Services.AddScoped<IData, AreaData>();
            builder.Services.AddScoped<IData, LengthData>();
            builder.Services.AddScoped<ITransformer, Transformer>();
            builder.Services.AddSingleton<AppSettings>();

            builder.Services.AddMudServices();

            var host = builder.Build();
            await host.RunAsync();
        }
    }
}
